
namespace FontAwesomeExamples
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new System.Windows.Forms.Label();
            fontAwesomeButton2 = new FontAwesomeControls.FontAwesomeButton();
            fontAwesomeLabel2 = new FontAwesomeControls.FontAwesomeLabel();
            fontAwesomeLabel3 = new FontAwesomeControls.FontAwesomeLabel();
            fontAwesomeLabel5 = new FontAwesomeControls.FontAwesomeLabel();
            fontAwesomePicture3 = new FontAwesomeControls.FontAwesomePicture();
            fontAwesomeLabel4 = new FontAwesomeControls.FontAwesomeLabel();
            fontAwesomeSingle2 = new FontAwesomeControls.FontAwesomeSingle();
            ((System.ComponentModel.ISupportInitialize)fontAwesomePicture3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            label1.Location = new System.Drawing.Point(94, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(412, 30);
            label1.TabIndex = 0;
            label1.Text = "Controls FontAwesome for Windows Forms";
            // 
            // fontAwesomeButton2
            // 
            fontAwesomeButton2.IconColor = System.Drawing.Color.FromArgb(255, 128, 0);
            fontAwesomeButton2.IconName = "shopping-cart";
            fontAwesomeButton2.IconType = FontAwesomeControls.Infrastucture.Entities.IconType.Duotone;
            fontAwesomeButton2.IconWidth = 25;
            fontAwesomeButton2.Image = (System.Drawing.Image)resources.GetObject("fontAwesomeButton2.Image");
            fontAwesomeButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            fontAwesomeButton2.Location = new System.Drawing.Point(198, 85);
            fontAwesomeButton2.Name = "fontAwesomeButton2";
            fontAwesomeButton2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            fontAwesomeButton2.Size = new System.Drawing.Size(174, 60);
            fontAwesomeButton2.TabIndex = 1;
            fontAwesomeButton2.Text = "   button with icon";
            fontAwesomeButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            fontAwesomeButton2.UseVisualStyleBackColor = true;
            // 
            // fontAwesomeLabel2
            // 
            fontAwesomeLabel2.AutoSize = true;
            fontAwesomeLabel2.IconColor = System.Drawing.Color.FromArgb(0, 192, 192);
            fontAwesomeLabel2.IconName = "star";
            fontAwesomeLabel2.IconType = FontAwesomeControls.Infrastucture.Entities.IconType.Regular;
            fontAwesomeLabel2.IconWidth = 20;
            fontAwesomeLabel2.Image = (System.Drawing.Image)resources.GetObject("fontAwesomeLabel2.Image");
            fontAwesomeLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            fontAwesomeLabel2.Location = new System.Drawing.Point(129, 197);
            fontAwesomeLabel2.Name = "fontAwesomeLabel2";
            fontAwesomeLabel2.Size = new System.Drawing.Size(159, 15);
            fontAwesomeLabel2.TabIndex = 2;
            fontAwesomeLabel2.Text = "         label with icon - regular";
            fontAwesomeLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fontAwesomeLabel3
            // 
            fontAwesomeLabel3.AutoSize = true;
            fontAwesomeLabel3.IconColor = System.Drawing.Color.FromArgb(0, 192, 192);
            fontAwesomeLabel3.IconName = "star";
            fontAwesomeLabel3.IconType = FontAwesomeControls.Infrastucture.Entities.IconType.Solid;
            fontAwesomeLabel3.IconWidth = 20;
            fontAwesomeLabel3.Image = (System.Drawing.Image)resources.GetObject("fontAwesomeLabel3.Image");
            fontAwesomeLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            fontAwesomeLabel3.Location = new System.Drawing.Point(129, 221);
            fontAwesomeLabel3.Name = "fontAwesomeLabel3";
            fontAwesomeLabel3.Size = new System.Drawing.Size(147, 15);
            fontAwesomeLabel3.TabIndex = 5;
            fontAwesomeLabel3.Text = "         label with icon - solid";
            fontAwesomeLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fontAwesomeLabel5
            // 
            fontAwesomeLabel5.AutoSize = true;
            fontAwesomeLabel5.IconColor = System.Drawing.Color.FromArgb(0, 192, 192);
            fontAwesomeLabel5.IconName = "star";
            fontAwesomeLabel5.IconType = FontAwesomeControls.Infrastucture.Entities.IconType.Duotone;
            fontAwesomeLabel5.IconWidth = 20;
            fontAwesomeLabel5.Image = (System.Drawing.Image)resources.GetObject("fontAwesomeLabel5.Image");
            fontAwesomeLabel5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            fontAwesomeLabel5.Location = new System.Drawing.Point(294, 221);
            fontAwesomeLabel5.Name = "fontAwesomeLabel5";
            fontAwesomeLabel5.Size = new System.Drawing.Size(167, 15);
            fontAwesomeLabel5.TabIndex = 7;
            fontAwesomeLabel5.Text = "         label with icon - duotone";
            fontAwesomeLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fontAwesomePicture3
            // 
            fontAwesomePicture3.BackgroundIconColor = System.Drawing.Color.FromArgb(152, 102, 0);
            fontAwesomePicture3.BackgroundIconName = "circle";
            fontAwesomePicture3.BackgroundIconType = FontAwesomeControls.Infrastucture.Entities.IconType.Solid;
            fontAwesomePicture3.BackgroundIconWidth = 200;
            fontAwesomePicture3.BackgroundImage = (System.Drawing.Image)resources.GetObject("fontAwesomePicture3.BackgroundImage");
            fontAwesomePicture3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            fontAwesomePicture3.IconColor = System.Drawing.Color.White;
            fontAwesomePicture3.IconName = "trophy";
            fontAwesomePicture3.IconType = FontAwesomeControls.Infrastucture.Entities.IconType.Solid;
            fontAwesomePicture3.IconWidth = 40;
            fontAwesomePicture3.Image = (System.Drawing.Image)resources.GetObject("fontAwesomePicture3.Image");
            fontAwesomePicture3.Location = new System.Drawing.Point(174, 275);
            fontAwesomePicture3.Name = "fontAwesomePicture3";
            fontAwesomePicture3.Size = new System.Drawing.Size(86, 81);
            fontAwesomePicture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            fontAwesomePicture3.TabIndex = 8;
            fontAwesomePicture3.TabStop = false;
            // 
            // fontAwesomeLabel4
            // 
            fontAwesomeLabel4.AutoSize = true;
            fontAwesomeLabel4.IconColor = System.Drawing.Color.FromArgb(0, 192, 192);
            fontAwesomeLabel4.IconName = "star";
            fontAwesomeLabel4.IconType = FontAwesomeControls.Infrastucture.Entities.IconType.Light;
            fontAwesomeLabel4.IconWidth = 20;
            fontAwesomeLabel4.Image = (System.Drawing.Image)resources.GetObject("fontAwesomeLabel4.Image");
            fontAwesomeLabel4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            fontAwesomeLabel4.Location = new System.Drawing.Point(294, 197);
            fontAwesomeLabel4.Name = "fontAwesomeLabel4";
            fontAwesomeLabel4.Size = new System.Drawing.Size(143, 15);
            fontAwesomeLabel4.TabIndex = 9;
            fontAwesomeLabel4.Text = "         label with icon- light";
            fontAwesomeLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fontAwesomeSingle2
            // 
            fontAwesomeSingle2.BackgroundImage = (System.Drawing.Image)resources.GetObject("fontAwesomeSingle2.BackgroundImage");
            fontAwesomeSingle2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            fontAwesomeSingle2.IconColor = System.Drawing.Color.FromArgb(0, 192, 0);
            fontAwesomeSingle2.IconName = "user";
            fontAwesomeSingle2.IconType = FontAwesomeControls.Infrastucture.Entities.IconType.Solid;
            fontAwesomeSingle2.Location = new System.Drawing.Point(303, 275);
            fontAwesomeSingle2.Name = "fontAwesomeSingle2";
            fontAwesomeSingle2.Size = new System.Drawing.Size(82, 81);
            fontAwesomeSingle2.TabIndex = 10;
            fontAwesomeSingle2.Text = "fontAwesomeSingle2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(560, 408);
            Controls.Add(fontAwesomeSingle2);
            Controls.Add(fontAwesomeLabel4);
            Controls.Add(fontAwesomePicture3);
            Controls.Add(fontAwesomeLabel5);
            Controls.Add(fontAwesomeLabel3);
            Controls.Add(fontAwesomeLabel2);
            Controls.Add(fontAwesomeButton2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)fontAwesomePicture3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesomeControls.FontAwesomeButton fontAwesomeButton1;
        private FontAwesomeControls.FontAwesomeLabel fontAwesomeLabel1;
        private FontAwesomeControls.FontAwesomePicture fontAwesomePicture1;
        private FontAwesomeControls.FontAwesomeSingle fontAwesomeSingle1;
        private System.Windows.Forms.Label label1;
        private FontAwesomeControls.FontAwesomeButton fontAwesomeButton2;
        private FontAwesomeControls.FontAwesomeLabel fontAwesomeLabel2;
        private FontAwesomeControls.FontAwesomeLabel fontAwesomeLabel3;
        private FontAwesomeControls.FontAwesomeLabel fontAwesomeLabel5;
        private FontAwesomeControls.FontAwesomePicture fontAwesomePicture3;
        private FontAwesomeControls.FontAwesomeLabel fontAwesomeLabel4;
        private FontAwesomeControls.FontAwesomeSingle fontAwesomeSingle2;
    }
}