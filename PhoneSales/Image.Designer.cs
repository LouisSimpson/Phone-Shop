namespace PhoneSales
{
    partial class Image
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Image));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "apple-iphone-4-ofic-final.jpg");
            this.imageList1.Images.SetKeyName(1, "apple-iphone-4s-new.jpg");
            this.imageList1.Images.SetKeyName(2, "apple-iphone-5-ofic.jpg");
            this.imageList1.Images.SetKeyName(3, "apple-iphone-5se-ofic.jpg");
            this.imageList1.Images.SetKeyName(4, "apple-iphone-6s1.jpg");
            this.imageList1.Images.SetKeyName(5, "apple-iphone-7r4.jpg");
            this.imageList1.Images.SetKeyName(6, "ca83636a-6fe9-452c-82e1-af4b8f19e495.png");
            this.imageList1.Images.SetKeyName(7, "htc-one-m9-global-sketchfab-gunmetal.png");
            this.imageList1.Images.SetKeyName(8, "oneplus-3-3.jpg");
            this.imageList1.Images.SetKeyName(9, "PRO_SamsungGs5_white.png");
            this.imageList1.Images.SetKeyName(10, "samsung-galaxy-s6.jpg");
            this.imageList1.Images.SetKeyName(11, "The-rumored-OnePlus-3S-might-actually-be-called-the-OnePlus-3T.jpg");
            // 
            // Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Image";
            this.Text = "Image";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
    }
}