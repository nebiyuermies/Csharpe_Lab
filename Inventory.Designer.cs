﻿
namespace WformLab
{
    partial class Inventory
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtinventory = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtobjname = new System.Windows.Forms.TextBox();
            this.txtcount = new System.Windows.Forms.TextBox();
            this.txtcprice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.displaytbl = new System.Windows.Forms.DataGridView();
            this.errorPvd = new System.Windows.Forms.ErrorProvider(this.components);
            this.chbox = new System.Windows.Forms.CheckBox();
            this.cklistbox = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rbtnvar = new System.Windows.Forms.RadioButton();
            this.rbtsimple = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.user = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.displaytbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPvd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "number";
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(33, 68);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(143, 20);
            this.txtnum.TabIndex = 1;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(33, 276);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(432, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Inventory Number";
            // 
            // txtinventory
            // 
            this.txtinventory.Location = new System.Drawing.Point(437, 68);
            this.txtinventory.Name = "txtinventory";
            this.txtinventory.Size = new System.Drawing.Size(143, 20);
            this.txtinventory.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Object name";
            // 
            // txtobjname
            // 
            this.txtobjname.Location = new System.Drawing.Point(35, 155);
            this.txtobjname.Name = "txtobjname";
            this.txtobjname.Size = new System.Drawing.Size(545, 20);
            this.txtobjname.TabIndex = 8;
            // 
            // txtcount
            // 
            this.txtcount.Location = new System.Drawing.Point(33, 234);
            this.txtcount.Name = "txtcount";
            this.txtcount.Size = new System.Drawing.Size(143, 20);
            this.txtcount.TabIndex = 9;
            // 
            // txtcprice
            // 
            this.txtcprice.Location = new System.Drawing.Point(226, 234);
            this.txtcprice.Name = "txtcprice";
            this.txtcprice.Size = new System.Drawing.Size(143, 20);
            this.txtcprice.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(221, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Price";
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(238, 68);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(143, 20);
            this.txtdate.TabIndex = 5;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(224, 276);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 13;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // displaytbl
            // 
            this.displaytbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displaytbl.Location = new System.Drawing.Point(12, 305);
            this.displaytbl.Name = "displaytbl";
            this.displaytbl.Size = new System.Drawing.Size(776, 150);
            this.displaytbl.TabIndex = 15;
            this.displaytbl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displaytbl_CellContentClick);
            // 
            // errorPvd
            // 
            this.errorPvd.ContainerControl = this;
            // 
            // chbox
            // 
            this.chbox.AutoSize = true;
            this.chbox.Location = new System.Drawing.Point(544, 234);
            this.chbox.Name = "chbox";
            this.chbox.Size = new System.Drawing.Size(76, 17);
            this.chbox.TabIndex = 16;
            this.chbox.Text = "is avalable";
            this.chbox.UseVisualStyleBackColor = true;
            this.chbox.CheckedChanged += new System.EventHandler(this.chbox_CheckedChanged);
            // 
            // cklistbox
            // 
            this.cklistbox.FormattingEnabled = true;
            this.cklistbox.Items.AddRange(new object[] {
            "is cheacked",
            "fruit",
            "vegi"});
            this.cklistbox.Location = new System.Drawing.Point(660, 30);
            this.cklistbox.Name = "cklistbox";
            this.cklistbox.Size = new System.Drawing.Size(120, 94);
            this.cklistbox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(660, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbtnvar
            // 
            this.rbtnvar.AutoSize = true;
            this.rbtnvar.Location = new System.Drawing.Point(437, 276);
            this.rbtnvar.Name = "rbtnvar";
            this.rbtnvar.Size = new System.Drawing.Size(61, 17);
            this.rbtnvar.TabIndex = 19;
            this.rbtnvar.TabStop = true;
            this.rbtnvar.Text = "Varable";
            this.rbtnvar.UseVisualStyleBackColor = true;
            // 
            // rbtsimple
            // 
            this.rbtsimple.AutoSize = true;
            this.rbtsimple.Location = new System.Drawing.Point(437, 237);
            this.rbtsimple.Name = "rbtsimple";
            this.rbtsimple.Size = new System.Drawing.Size(54, 17);
            this.rbtsimple.TabIndex = 20;
            this.rbtsimple.TabStop = true;
            this.rbtsimple.Text = "simple";
            this.rbtsimple.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(588, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "paypal";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(119, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "payment on delivery";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(358, 115);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(54, 25);
            this.user.TabIndex = 22;
            this.user.Text = "user";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.user);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbtsimple);
            this.Controls.Add(this.rbtnvar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cklistbox);
            this.Controls.Add(this.chbox);
            this.Controls.Add(this.displaytbl);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcprice);
            this.Controls.Add(this.txtcount);
            this.Controls.Add(this.txtobjname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtinventory);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displaytbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPvd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtinventory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtobjname;
        private System.Windows.Forms.TextBox txtcount;
        private System.Windows.Forms.TextBox txtcprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.DataGridView displaytbl;
        private System.Windows.Forms.ErrorProvider errorPvd;
        private System.Windows.Forms.CheckBox chbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox cklistbox;
        private System.Windows.Forms.RadioButton rbtsimple;
        private System.Windows.Forms.RadioButton rbtnvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label user;
    }
}