
namespace Car_List_Winform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Model = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Vendor = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Year = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Engine = new Guna.UI.WinForms.GunaLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_ChangeCar = new System.Windows.Forms.Button();
            this.picbox_Car = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Car)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(80, 192);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(157, 47);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Vendor :";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(128, 255);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(109, 47);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Year :";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(86, 314);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(151, 47);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "Engine :";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(92, 125);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(145, 47);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "Model :";
            // 
            // lbl_Model
            // 
            this.lbl_Model.AutoSize = true;
            this.lbl_Model.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Model.Location = new System.Drawing.Point(249, 125);
            this.lbl_Model.Name = "lbl_Model";
            this.lbl_Model.Size = new System.Drawing.Size(0, 47);
            this.lbl_Model.TabIndex = 5;
            // 
            // lbl_Vendor
            // 
            this.lbl_Vendor.AutoSize = true;
            this.lbl_Vendor.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vendor.Location = new System.Drawing.Point(249, 192);
            this.lbl_Vendor.Name = "lbl_Vendor";
            this.lbl_Vendor.Size = new System.Drawing.Size(0, 47);
            this.lbl_Vendor.TabIndex = 6;
            // 
            // lbl_Year
            // 
            this.lbl_Year.AutoSize = true;
            this.lbl_Year.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Year.Location = new System.Drawing.Point(249, 255);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(0, 47);
            this.lbl_Year.TabIndex = 7;
            // 
            // lbl_Engine
            // 
            this.lbl_Engine.AutoSize = true;
            this.lbl_Engine.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Engine.Location = new System.Drawing.Point(249, 314);
            this.lbl_Engine.Name = "lbl_Engine";
            this.lbl_Engine.Size = new System.Drawing.Size(0, 47);
            this.lbl_Engine.TabIndex = 8;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Bmw m4.jpeg");
            this.imageList1.Images.SetKeyName(1, "Mercedes Benz Cls.jpeg");
            this.imageList1.Images.SetKeyName(2, "Hyundai Elantra.jpeg");
            this.imageList1.Images.SetKeyName(3, "Kia Sportage.jpeg");
            this.imageList1.Images.SetKeyName(4, "Lexus Rx350.jpeg");
            this.imageList1.Images.SetKeyName(5, "Ford Focus.jpeg");
            // 
            // btn_ChangeCar
            // 
            this.btn_ChangeCar.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_ChangeCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangeCar.ForeColor = System.Drawing.Color.Black;
            this.btn_ChangeCar.ImageList = this.imageList1;
            this.btn_ChangeCar.Location = new System.Drawing.Point(73, 389);
            this.btn_ChangeCar.Name = "btn_ChangeCar";
            this.btn_ChangeCar.Size = new System.Drawing.Size(372, 61);
            this.btn_ChangeCar.TabIndex = 10;
            this.btn_ChangeCar.Text = "Change";
            this.btn_ChangeCar.UseVisualStyleBackColor = false;
            this.btn_ChangeCar.Click += new System.EventHandler(this.btn_ChangeCar_Click);
            // 
            // picbox_Car
            // 
            this.picbox_Car.BaseColor = System.Drawing.Color.White;
            this.picbox_Car.Location = new System.Drawing.Point(632, 116);
            this.picbox_Car.Name = "picbox_Car";
            this.picbox_Car.Size = new System.Drawing.Size(505, 345);
            this.picbox_Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_Car.TabIndex = 11;
            this.picbox_Car.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 484);
            this.Controls.Add(this.picbox_Car);
            this.Controls.Add(this.btn_ChangeCar);
            this.Controls.Add(this.lbl_Engine);
            this.Controls.Add(this.lbl_Year);
            this.Controls.Add(this.lbl_Vendor);
            this.Controls.Add(this.lbl_Model);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.MaximumSize = new System.Drawing.Size(1165, 523);
            this.MinimumSize = new System.Drawing.Size(1165, 523);
            this.Name = "Form1";
            this.Text = "S";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Car)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lbl_Model;
        private Guna.UI.WinForms.GunaLabel lbl_Vendor;
        private Guna.UI.WinForms.GunaLabel lbl_Year;
        private Guna.UI.WinForms.GunaLabel lbl_Engine;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_ChangeCar;
        private Guna.UI.WinForms.GunaPictureBox picbox_Car;
    }
}

