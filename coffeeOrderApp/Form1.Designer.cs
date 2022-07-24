namespace coffeeOrderApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.coffee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_fnsh_order = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgw = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgw_orders = new System.Windows.Forms.DataGridView();
            this.c_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_orders)).BeginInit();
            this.SuspendLayout();
            // 
            // remove
            // 
            this.remove.HeaderText = "Cikart";
            this.remove.Name = "remove";
            // 
            // name
            // 
            this.name.HeaderText = "isim";
            this.name.Name = "name";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "isim";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // add
            // 
            this.add.FillWeight = 63.45178F;
            this.add.HeaderText = "Ekle";
            this.add.Name = "add";
            this.add.Text = "";
            this.add.Width = 50;
            // 
            // coffee
            // 
            this.coffee.FillWeight = 159.5123F;
            this.coffee.HeaderText = "Kahve";
            this.coffee.Name = "coffee";
            this.coffee.Width = 126;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Ekle";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Kahve";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "Ekle";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_reset.Location = new System.Drawing.Point(49, 415);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(205, 60);
            this.btn_reset.TabIndex = 0;
            this.btn_reset.Text = "SECIMI SIFIRLA";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_fnsh_order
            // 
            this.btn_fnsh_order.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_fnsh_order.Location = new System.Drawing.Point(291, 415);
            this.btn_fnsh_order.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_fnsh_order.Name = "btn_fnsh_order";
            this.btn_fnsh_order.Size = new System.Drawing.Size(204, 60);
            this.btn_fnsh_order.TabIndex = 1;
            this.btn_fnsh_order.Text = "SIPARISI TAMAMLA";
            this.btn_fnsh_order.UseVisualStyleBackColor = false;
            this.btn_fnsh_order.Click += new System.EventHandler(this.btn_fnsh_order_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Salmon;
            this.button3.Location = new System.Drawing.Point(529, 415);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "CIKIS";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgw
            // 
            this.dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw.Location = new System.Drawing.Point(40, 48);
            this.dgw.Name = "dgw";
            this.dgw.RowTemplate.Height = 25;
            this.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw.Size = new System.Drawing.Size(337, 333);
            this.dgw.TabIndex = 3;
            this.dgw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgw_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Moccasin;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(399, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Toplam Tutar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Moccasin;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(520, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "0";
            // 
            // dgw_orders
            // 
            this.dgw_orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_orders.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgw_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delete,
            this.c_name,
            this.c_price});
            this.dgw_orders.Location = new System.Drawing.Point(399, 48);
            this.dgw_orders.Name = "dgw_orders";
            this.dgw_orders.RowTemplate.Height = 25;
            this.dgw_orders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_orders.Size = new System.Drawing.Size(343, 269);
            this.dgw_orders.TabIndex = 6;
            this.dgw_orders.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgw_orders_MouseClick);
            // 
            // c_price
            // 
            this.c_price.HeaderText = "Fiyat";
            this.c_price.Name = "c_price";
            // 
            // c_name
            // 
            this.c_name.HeaderText = "Kahve";
            this.c_name.Name = "c_name";
            // 
            // delete
            // 
            this.delete.HeaderText = "Cikart";
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(785, 519);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgw_orders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_fnsh_order);
            this.Controls.Add(this.dgw);
            this.Controls.Add(this.btn_reset);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Kahve Siparis Uygulamasi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridViewButtonColumn remove;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewButtonColumn add;
        private DataGridViewTextBoxColumn coffee;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewButtonColumn dataGridViewButtonColumn2;
        private Button btn_reset;
        private Button btn_fnsh_order;
        private Button button3;
        private DataGridView dgw;
        private Label label1;
        private Label label2;
        private DataGridView dgw_orders;
        private DataGridViewButtonColumn delete;
        private DataGridViewTextBoxColumn c_name;
        private DataGridViewTextBoxColumn c_price;
    }
}