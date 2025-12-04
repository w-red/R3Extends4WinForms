namespace WinFormsSampleNet472
{
    partial class R3Extends4WinFormsSample
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.InputTb = new System.Windows.Forms.TextBox();
            this.ArrowLb = new System.Windows.Forms.Label();
            this.OutputTb = new System.Windows.Forms.TextBox();
            this.OptionsGb = new System.Windows.Forms.GroupBox();
            this.DeleteRb = new System.Windows.Forms.RadioButton();
            this.RawRb = new System.Windows.Forms.RadioButton();
            this.ToUpperRb = new System.Windows.Forms.RadioButton();
            this.ToLowerRb = new System.Windows.Forms.RadioButton();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.SampleViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OptionsGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SampleViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // InputTb
            // 
            this.InputTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SampleViewModelBindingSource, "InputText", true));
            this.InputTb.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.InputTb.Location = new System.Drawing.Point(33, 49);
            this.InputTb.Name = "InputTb";
            this.InputTb.Size = new System.Drawing.Size(217, 31);
            this.InputTb.TabIndex = 0;
            // 
            // ArrowLb
            // 
            this.ArrowLb.AutoSize = true;
            this.ArrowLb.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ArrowLb.Location = new System.Drawing.Point(256, 52);
            this.ArrowLb.Name = "ArrowLb";
            this.ArrowLb.Size = new System.Drawing.Size(34, 24);
            this.ArrowLb.TabIndex = 1;
            this.ArrowLb.Text = "=>";
            // 
            // OutputTb
            // 
            this.OutputTb.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OutputTb.Location = new System.Drawing.Point(296, 49);
            this.OutputTb.Name = "OutputTb";
            this.OutputTb.Size = new System.Drawing.Size(217, 31);
            this.OutputTb.TabIndex = 2;
            // 
            // OptionsGb
            // 
            this.OptionsGb.Controls.Add(this.DeleteRb);
            this.OptionsGb.Controls.Add(this.RawRb);
            this.OptionsGb.Controls.Add(this.ToUpperRb);
            this.OptionsGb.Controls.Add(this.ToLowerRb);
            this.OptionsGb.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OptionsGb.Location = new System.Drawing.Point(365, 86);
            this.OptionsGb.Name = "OptionsGb";
            this.OptionsGb.Size = new System.Drawing.Size(148, 141);
            this.OptionsGb.TabIndex = 3;
            this.OptionsGb.TabStop = false;
            this.OptionsGb.Text = "TranslateOptions";
            // 
            // DeleteRb
            // 
            this.DeleteRb.AutoSize = true;
            this.DeleteRb.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DeleteRb.Location = new System.Drawing.Point(24, 105);
            this.DeleteRb.Name = "DeleteRb";
            this.DeleteRb.Size = new System.Drawing.Size(68, 20);
            this.DeleteRb.TabIndex = 3;
            this.DeleteRb.Text = "Delete";
            this.DeleteRb.UseVisualStyleBackColor = true;
            // 
            // RawRb
            // 
            this.RawRb.AutoSize = true;
            this.RawRb.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RawRb.Location = new System.Drawing.Point(24, 79);
            this.RawRb.Name = "RawRb";
            this.RawRb.Size = new System.Drawing.Size(53, 20);
            this.RawRb.TabIndex = 2;
            this.RawRb.Text = "Raw";
            this.RawRb.UseVisualStyleBackColor = true;
            // 
            // ToUpperRb
            // 
            this.ToUpperRb.AutoSize = true;
            this.ToUpperRb.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ToUpperRb.Location = new System.Drawing.Point(24, 53);
            this.ToUpperRb.Name = "ToUpperRb";
            this.ToUpperRb.Size = new System.Drawing.Size(82, 20);
            this.ToUpperRb.TabIndex = 1;
            this.ToUpperRb.Text = "ToUpper";
            this.ToUpperRb.UseVisualStyleBackColor = true;
            // 
            // ToLowerRb
            // 
            this.ToLowerRb.AutoSize = true;
            this.ToLowerRb.Checked = true;
            this.ToLowerRb.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ToLowerRb.Location = new System.Drawing.Point(24, 27);
            this.ToLowerRb.Name = "ToLowerRb";
            this.ToLowerRb.Size = new System.Drawing.Size(83, 20);
            this.ToLowerRb.TabIndex = 0;
            this.ToLowerRb.TabStop = true;
            this.ToLowerRb.Text = "ToLower";
            this.ToLowerRb.UseVisualStyleBackColor = true;
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ExecuteButton.Location = new System.Drawing.Point(519, 191);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(188, 36);
            this.ExecuteButton.TabIndex = 4;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            // 
            // SampleViewModelBindingSource
            // 
            this.SampleViewModelBindingSource.DataSource = typeof(SampleCommonModules.R3Extends4WinFormsSampleViewModel);
            // 
            // R3Extends4WinFormsSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 261);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.OptionsGb);
            this.Controls.Add(this.OutputTb);
            this.Controls.Add(this.ArrowLb);
            this.Controls.Add(this.InputTb);
            this.Name = "R3Extends4WinFormsSample";
            this.Text = "R3Extends4WinFormsSample";
            this.OptionsGb.ResumeLayout(false);
            this.OptionsGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SampleViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputTb;
        private System.Windows.Forms.Label ArrowLb;
        private System.Windows.Forms.TextBox OutputTb;
        private System.Windows.Forms.GroupBox OptionsGb;
        private System.Windows.Forms.RadioButton DeleteRb;
        private System.Windows.Forms.RadioButton RawRb;
        private System.Windows.Forms.RadioButton ToUpperRb;
        private System.Windows.Forms.RadioButton ToLowerRb;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.BindingSource SampleViewModelBindingSource;
    }
}

