﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace PosterinoWinApp.Forms {
    public partial class fmQuery : Form {
        public fmQuery() {
            InitializeComponent();
        }

        private void fmQuery_Load(object sender, EventArgs e) {
            // Set default values for various controls.
            this.setDefaultValues();
        }

        /// <summary>
        /// Set default values for various controls.
        /// </summary>
        private void setDefaultValues() {
            this.cbMethod.SelectedIndex = 0;
        }

        /// <summary>
        /// Handle and output HttpWebResponse.
        /// </summary>
        private void handleHttpWebResponse(HttpWebResponse res, TimeSpan time) {
            // Time
            this.lblTime.Text = string.Format("{0}ms", time.Milliseconds);

            if (time.Seconds > 0) {
                this.lblTime.Text = string.Format(
                    "{0}s, {1}",
                    time.Seconds,
                    this.lblTime.Text);
            }

            if (time.Minutes > 0) {
                this.lblTime.Text = string.Format(
                    "{0}m, {1}",
                    time.Minutes,
                    this.lblTime.Text);
            }

            // Status
            this.lblStatus.Text = string.Format(
                "{0} {1}",
                (int) res.StatusCode,
                res.StatusDescription);

            // Body
            var bytes = 0;
            var stream = res.GetResponseStream();

            if (stream != null) {
                var reader = new StreamReader(stream);
                var body = reader.ReadToEnd();

                bytes = body.Length;

                if (body.Contains("\r") &&
                    !body.Contains("\n")) {

                    body = body.Replace("\r", "\r\n");
                }
                else if (body.Contains("\n") &&
                         !body.Contains("\r")) {

                    body = body.Replace("\n", "\r\n");
                }

                this.tbResponseBody.Text = body;
            }
            else {
                this.tbResponseBody.Text = string.Empty;
            }

            // Headers
            this.lsResponseHeaders.Items.Clear();

            foreach (var header in res.Headers) {
                var item = new ListViewItem(new [] {
                    header.ToString(),
                    res.Headers[header.ToString()]
                });

                this.lsResponseHeaders.Items.Add(item);
            }

            // Size
            this.lbSize.Text = bytes > 1024
                ? string.Format("{0} KB", (double) bytes / 1024)
                : string.Format("{0} B", bytes);
        }

        /// <summary>
        /// Query the resource.
        /// </summary>
        private void btSend_Click(object sender, EventArgs e) {
            this.btSend.Text = "Working";
            Application.DoEvents();

            var url = this.tbURL.Text.Trim();
            var headers = new Dictionary<string, string>();

            if (!string.IsNullOrWhiteSpace(this.tbHeaderKey1.Text)) {
                headers.Add(this.tbHeaderKey1.Text.Trim(), this.tbHeaderValue1.Text.Trim());
            }

            if (!string.IsNullOrWhiteSpace(this.tbHeaderKey2.Text)) {
                headers.Add(this.tbHeaderKey2.Text.Trim(), this.tbHeaderValue2.Text.Trim());
            }

            if (!string.IsNullOrWhiteSpace(this.tbHeaderKey3.Text)) {
                headers.Add(this.tbHeaderKey3.Text.Trim(), this.tbHeaderValue3.Text.Trim());
            }

            if (!string.IsNullOrWhiteSpace(this.tbHeaderKey4.Text)) {
                headers.Add(this.tbHeaderKey4.Text.Trim(), this.tbHeaderValue4.Text.Trim());
            }

            if (!string.IsNullOrWhiteSpace(this.tbRequestBody.Text)) {
                var bytes = Encoding.UTF8.GetBytes(this.tbRequestBody.Text);

                headers.Add("Content-Length", bytes.Length.ToString());
            }

            try {
                var req = WebRequest.Create(url) as HttpWebRequest;

                if (req == null) {
                    throw new Exception(
                        string.Format(
                            "Could not create WebRequest for URL: {0}",
                            url));
                }

                // Method
                req.Method = this.cbMethod.SelectedItem.ToString().ToUpper();

                // Headers
                if (headers.Any()) {
                    foreach (var header in headers) {
                        switch (header.Key.ToLower()) {
                            case "content-length":
                                if (long.TryParse(header.Value, out var temp)) {
                                    req.ContentLength = temp;
                                }

                                break;

                            case "content-type":
                                req.ContentType = header.Value;
                                break;

                            default:
                                req.Headers.Add(header.Key, header.Value);
                                break;
                        }
                    }
                }

                // Body
                if (!string.IsNullOrWhiteSpace(this.tbRequestBody.Text)) {
                    var bytes = Encoding.UTF8.GetBytes(this.tbRequestBody.Text);
                    var stream = req.GetRequestStream();

                    stream.Write(
                        bytes,
                        0,
                        bytes.Length);
                }

                var start = DateTime.Now;
                var res = req.GetResponse() as HttpWebResponse;
                var end = DateTime.Now;

                if (res == null) {
                    throw new Exception("Could not get response from request");
                }

                this.handleHttpWebResponse(res, end - start);
            }
            catch (WebException ex) {
                var start = DateTime.Now;
                var res = ex.Response as HttpWebResponse;
                var end = DateTime.Now;

                if (res == null) {
                    throw;
                }

                this.handleHttpWebResponse(res, end - start);
            }
            catch (Exception ex) {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            this.btSend.Text = "Send";
        }
    }
}