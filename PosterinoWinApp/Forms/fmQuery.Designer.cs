namespace PosterinoWinApp.Forms
{
    partial class fmQuery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbMethod = new System.Windows.Forms.ComboBox();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpRequestHeaders = new System.Windows.Forms.TabPage();
            this.tpRequestBody = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHeaderKey1 = new System.Windows.Forms.TextBox();
            this.tbHeaderKey2 = new System.Windows.Forms.TextBox();
            this.tbHeaderKey3 = new System.Windows.Forms.TextBox();
            this.tbHeaderKey4 = new System.Windows.Forms.TextBox();
            this.tbHeaderValue4 = new System.Windows.Forms.TextBox();
            this.tbHeaderValue3 = new System.Windows.Forms.TextBox();
            this.tbHeaderValue2 = new System.Windows.Forms.TextBox();
            this.tbHeaderValue1 = new System.Windows.Forms.TextBox();
            this.tbRequestBody = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbResponseBody = new System.Windows.Forms.TextBox();
            this.lsResponseHeaders = new System.Windows.Forms.ListView();
            this.chKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tpRequestHeaders.SuspendLayout();
            this.tpRequestBody.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbMethod
            // 
            this.cbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMethod.FormattingEnabled = true;
            this.cbMethod.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE",
            "HEAD",
            "OPTIONS"});
            this.cbMethod.Location = new System.Drawing.Point(12, 12);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(91, 21);
            this.cbMethod.TabIndex = 0;
            // 
            // tbURL
            // 
            this.tbURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbURL.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbURL.Location = new System.Drawing.Point(12, 39);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(1390, 26);
            this.tbURL.TabIndex = 1;
            // 
            // btSend
            // 
            this.btSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSend.Location = new System.Drawing.Point(1408, 39);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(76, 26);
            this.btSend.TabIndex = 2;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpRequestHeaders);
            this.tabControl1.Controls.Add(this.tpRequestBody);
            this.tabControl1.Location = new System.Drawing.Point(12, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1472, 181);
            this.tabControl1.TabIndex = 3;
            // 
            // tpRequestHeaders
            // 
            this.tpRequestHeaders.Controls.Add(this.tbHeaderValue4);
            this.tpRequestHeaders.Controls.Add(this.tbHeaderValue3);
            this.tpRequestHeaders.Controls.Add(this.tbHeaderValue2);
            this.tpRequestHeaders.Controls.Add(this.tbHeaderValue1);
            this.tpRequestHeaders.Controls.Add(this.tbHeaderKey4);
            this.tpRequestHeaders.Controls.Add(this.tbHeaderKey3);
            this.tpRequestHeaders.Controls.Add(this.tbHeaderKey2);
            this.tpRequestHeaders.Controls.Add(this.tbHeaderKey1);
            this.tpRequestHeaders.Controls.Add(this.label2);
            this.tpRequestHeaders.Controls.Add(this.label1);
            this.tpRequestHeaders.Location = new System.Drawing.Point(4, 22);
            this.tpRequestHeaders.Name = "tpRequestHeaders";
            this.tpRequestHeaders.Size = new System.Drawing.Size(1464, 155);
            this.tpRequestHeaders.TabIndex = 0;
            this.tpRequestHeaders.Text = "Headers";
            this.tpRequestHeaders.UseVisualStyleBackColor = true;
            // 
            // tpRequestBody
            // 
            this.tpRequestBody.Controls.Add(this.tbRequestBody);
            this.tpRequestBody.Location = new System.Drawing.Point(4, 22);
            this.tpRequestBody.Name = "tpRequestBody";
            this.tpRequestBody.Size = new System.Drawing.Size(1464, 155);
            this.tpRequestBody.TabIndex = 1;
            this.tpRequestBody.Text = "Body";
            this.tpRequestBody.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Value";
            // 
            // tbHeaderKey1
            // 
            this.tbHeaderKey1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHeaderKey1.Location = new System.Drawing.Point(18, 30);
            this.tbHeaderKey1.Name = "tbHeaderKey1";
            this.tbHeaderKey1.Size = new System.Drawing.Size(206, 26);
            this.tbHeaderKey1.TabIndex = 2;
            // 
            // tbHeaderKey2
            // 
            this.tbHeaderKey2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHeaderKey2.Location = new System.Drawing.Point(18, 57);
            this.tbHeaderKey2.Name = "tbHeaderKey2";
            this.tbHeaderKey2.Size = new System.Drawing.Size(206, 26);
            this.tbHeaderKey2.TabIndex = 3;
            // 
            // tbHeaderKey3
            // 
            this.tbHeaderKey3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHeaderKey3.Location = new System.Drawing.Point(18, 84);
            this.tbHeaderKey3.Name = "tbHeaderKey3";
            this.tbHeaderKey3.Size = new System.Drawing.Size(206, 26);
            this.tbHeaderKey3.TabIndex = 4;
            // 
            // tbHeaderKey4
            // 
            this.tbHeaderKey4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHeaderKey4.Location = new System.Drawing.Point(18, 111);
            this.tbHeaderKey4.Name = "tbHeaderKey4";
            this.tbHeaderKey4.Size = new System.Drawing.Size(206, 26);
            this.tbHeaderKey4.TabIndex = 5;
            // 
            // tbHeaderValue4
            // 
            this.tbHeaderValue4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHeaderValue4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHeaderValue4.Location = new System.Drawing.Point(249, 111);
            this.tbHeaderValue4.Name = "tbHeaderValue4";
            this.tbHeaderValue4.Size = new System.Drawing.Size(1196, 26);
            this.tbHeaderValue4.TabIndex = 9;
            // 
            // tbHeaderValue3
            // 
            this.tbHeaderValue3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHeaderValue3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHeaderValue3.Location = new System.Drawing.Point(249, 84);
            this.tbHeaderValue3.Name = "tbHeaderValue3";
            this.tbHeaderValue3.Size = new System.Drawing.Size(1196, 26);
            this.tbHeaderValue3.TabIndex = 8;
            // 
            // tbHeaderValue2
            // 
            this.tbHeaderValue2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHeaderValue2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHeaderValue2.Location = new System.Drawing.Point(249, 57);
            this.tbHeaderValue2.Name = "tbHeaderValue2";
            this.tbHeaderValue2.Size = new System.Drawing.Size(1196, 26);
            this.tbHeaderValue2.TabIndex = 7;
            // 
            // tbHeaderValue1
            // 
            this.tbHeaderValue1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHeaderValue1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHeaderValue1.Location = new System.Drawing.Point(249, 30);
            this.tbHeaderValue1.Name = "tbHeaderValue1";
            this.tbHeaderValue1.Size = new System.Drawing.Size(1196, 26);
            this.tbHeaderValue1.TabIndex = 6;
            // 
            // tbRequestBody
            // 
            this.tbRequestBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRequestBody.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRequestBody.Location = new System.Drawing.Point(18, 19);
            this.tbRequestBody.Multiline = true;
            this.tbRequestBody.Name = "tbRequestBody";
            this.tbRequestBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbRequestBody.Size = new System.Drawing.Size(1427, 118);
            this.tbRequestBody.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Size:";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(49, 264);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(10, 13);
            this.lbSize.TabIndex = 7;
            this.lbSize.Text = "-";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(158, 264);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(10, 13);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Time:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(278, 264);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(10, 13);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Status:";
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(12, 280);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1472, 501);
            this.tabControl2.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lsResponseHeaders);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1464, 475);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Headers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbResponseBody);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1464, 475);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Body";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbResponseBody
            // 
            this.tbResponseBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResponseBody.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResponseBody.Location = new System.Drawing.Point(18, 19);
            this.tbResponseBody.Multiline = true;
            this.tbResponseBody.Name = "tbResponseBody";
            this.tbResponseBody.ReadOnly = true;
            this.tbResponseBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbResponseBody.Size = new System.Drawing.Size(1427, 438);
            this.tbResponseBody.TabIndex = 0;
            // 
            // lsResponseHeaders
            // 
            this.lsResponseHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsResponseHeaders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chKey,
            this.chValue});
            this.lsResponseHeaders.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsResponseHeaders.FullRowSelect = true;
            this.lsResponseHeaders.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsResponseHeaders.Location = new System.Drawing.Point(18, 19);
            this.lsResponseHeaders.Name = "lsResponseHeaders";
            this.lsResponseHeaders.Size = new System.Drawing.Size(1427, 438);
            this.lsResponseHeaders.TabIndex = 0;
            this.lsResponseHeaders.UseCompatibleStateImageBehavior = false;
            this.lsResponseHeaders.View = System.Windows.Forms.View.Details;
            // 
            // chKey
            // 
            this.chKey.Text = "Key";
            this.chKey.Width = 300;
            // 
            // chValue
            // 
            this.chValue.Text = "Value";
            this.chValue.Width = 700;
            // 
            // fmQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 793);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.cbMethod);
            this.Controls.Add(this.tabControl2);
            this.Name = "fmQuery";
            this.Text = "fmQuery";
            this.Load += new System.EventHandler(this.fmQuery_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpRequestHeaders.ResumeLayout(false);
            this.tpRequestHeaders.PerformLayout();
            this.tpRequestBody.ResumeLayout(false);
            this.tpRequestBody.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMethod;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpRequestHeaders;
        private System.Windows.Forms.TextBox tbHeaderValue4;
        private System.Windows.Forms.TextBox tbHeaderValue3;
        private System.Windows.Forms.TextBox tbHeaderValue2;
        private System.Windows.Forms.TextBox tbHeaderValue1;
        private System.Windows.Forms.TextBox tbHeaderKey4;
        private System.Windows.Forms.TextBox tbHeaderKey3;
        private System.Windows.Forms.TextBox tbHeaderKey2;
        private System.Windows.Forms.TextBox tbHeaderKey1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpRequestBody;
        private System.Windows.Forms.TextBox tbRequestBody;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lsResponseHeaders;
        private System.Windows.Forms.ColumnHeader chKey;
        private System.Windows.Forms.ColumnHeader chValue;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbResponseBody;
    }
}