namespace cursovoy_var17
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Decorators = new System.Windows.Forms.ToolStripMenuItem();
            this.Educations = new System.Windows.Forms.ToolStripMenuItem();
            this.Parks = new System.Windows.Forms.ToolStripMenuItem();
            this.ZonesParks = new System.Windows.Forms.ToolStripMenuItem();
            this.Watering = new System.Windows.Forms.ToolStripMenuItem();
            this.Plants = new System.Windows.Forms.ToolStripMenuItem();
            this.TypePlants = new System.Windows.Forms.ToolStripMenuItem();
            this.Work = new System.Windows.Forms.ToolStripMenuItem();
            this.Employee = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QueryFirst = new System.Windows.Forms.ToolStripMenuItem();
            this.QuerySecond = new System.Windows.Forms.ToolStripMenuItem();
            this.QueryThird = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.parkDataSet = new cursovoy_var17.ParkDataSet();
            this.parkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parkTableAdapter = new cursovoy_var17.ParkDataSetTableAdapters.parkTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.данныеToolStripMenuItem,
            this.запросыToolStripMenuItem,
            this.About});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1070, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // данныеToolStripMenuItem
            // 
            this.данныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Decorators,
            this.Educations,
            this.Parks,
            this.ZonesParks,
            this.Watering,
            this.Plants,
            this.TypePlants,
            this.Work,
            this.Employee});
            this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
            this.данныеToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.данныеToolStripMenuItem.Text = "Данные";
            // 
            // Decorators
            // 
            this.Decorators.Name = "Decorators";
            this.Decorators.Size = new System.Drawing.Size(159, 22);
            this.Decorators.Text = "Декораторы";
            this.Decorators.Click += new System.EventHandler(this.DecoratorsWindowClick);
            // 
            // Educations
            // 
            this.Educations.Name = "Educations";
            this.Educations.Size = new System.Drawing.Size(159, 22);
            this.Educations.Text = "Образование";
            this.Educations.Click += new System.EventHandler(this.EducationsWindowClick);
            // 
            // Parks
            // 
            this.Parks.Name = "Parks";
            this.Parks.Size = new System.Drawing.Size(159, 22);
            this.Parks.Text = "Парки";
            this.Parks.Click += new System.EventHandler(this.ParksWindowClick);
            // 
            // ZonesParks
            // 
            this.ZonesParks.Name = "ZonesParks";
            this.ZonesParks.Size = new System.Drawing.Size(159, 22);
            this.ZonesParks.Text = "Зоны парков";
            this.ZonesParks.Click += new System.EventHandler(this.ZonesParksWindowClick);
            // 
            // Watering
            // 
            this.Watering.Name = "Watering";
            this.Watering.Size = new System.Drawing.Size(159, 22);
            this.Watering.Text = "Полив";
            this.Watering.Click += new System.EventHandler(this.WateringWindowClick);
            // 
            // Plants
            // 
            this.Plants.Name = "Plants";
            this.Plants.Size = new System.Drawing.Size(159, 22);
            this.Plants.Text = "Растения";
            this.Plants.Click += new System.EventHandler(this.PlantsWindowClick);
            // 
            // TypePlants
            // 
            this.TypePlants.Name = "TypePlants";
            this.TypePlants.Size = new System.Drawing.Size(159, 22);
            this.TypePlants.Text = "Виды растений";
            this.TypePlants.Click += new System.EventHandler(this.TypePlantsWindowClick);
            // 
            // Work
            // 
            this.Work.Name = "Work";
            this.Work.Size = new System.Drawing.Size(159, 22);
            this.Work.Text = "График работы";
            this.Work.Click += new System.EventHandler(this.WorkWindowClick);
            // 
            // Employee
            // 
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(159, 22);
            this.Employee.Text = "Сотрудники";
            this.Employee.Click += new System.EventHandler(this.EmployeeWindowClick);
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QueryFirst,
            this.QuerySecond,
            this.QueryThird});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.запросыToolStripMenuItem.Text = "Запросы";
            // 
            // QueryFirst
            // 
            this.QueryFirst.Name = "QueryFirst";
            this.QueryFirst.Size = new System.Drawing.Size(376, 22);
            this.QueryFirst.Text = "Полная информация о растении заданного вида";
            this.QueryFirst.Click += new System.EventHandler(this.QueryFirstWindowClick);
            // 
            // QuerySecond
            // 
            this.QuerySecond.Name = "QuerySecond";
            this.QuerySecond.Size = new System.Drawing.Size(376, 22);
            this.QuerySecond.Text = "Список сотрудников, работающих в заданную дату";
            this.QuerySecond.Click += new System.EventHandler(this.QuerySecondWindowClick);
            // 
            // QueryThird
            // 
            this.QueryThird.Name = "QueryThird";
            this.QueryThird.Size = new System.Drawing.Size(376, 22);
            this.QueryThird.Text = "Список растений на заданную дату и режим их полива";
            this.QueryThird.Click += new System.EventHandler(this.QueryThird_Click);
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(94, 20);
            this.About.Text = "О программе";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // parkDataSet
            // 
            this.parkDataSet.DataSetName = "ParkDataSet";
            this.parkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parkBindingSource
            // 
            this.parkBindingSource.DataMember = "park";
            this.parkBindingSource.DataSource = this.parkDataSet;
            // 
            // parkTableAdapter
            // 
            this.parkTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 450);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1070, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(793, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(290, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 319);
            this.panel1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Рабочий: +7-473-256-99-97";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(3, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(363, 36);
            this.label7.TabIndex = 6;
            this.label7.Text = "Занимается облагораживанием парков,  скверов,  формированием ландшафтов, озеленен" +
    "ием улиц";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Сайт: park-pro.com";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "e-mail: garden_best@yandex.ru";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Рабочий: +7-473-256-99-93";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Телефон: +7-900-693-33-32";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Юридический адрес: г. Воронеж, ул. Моквоский проспект, 115/5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Компания \"ParkPro\"";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::cursovoy_var17.Properties.Resources.tree_1716991_1280;
            this.pictureBox3.Location = new System.Drawing.Point(12, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(272, 400);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1070, 553);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1086, 592);
            this.Name = "Main";
            this.Text = "Компания \"ParkPro\"";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem данныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Decorators;
        private System.Windows.Forms.ToolStripMenuItem Educations;
        private System.Windows.Forms.ToolStripMenuItem Parks;
        private System.Windows.Forms.ToolStripMenuItem ZonesParks;
        private System.Windows.Forms.ToolStripMenuItem Watering;
        private System.Windows.Forms.ToolStripMenuItem Plants;
        private System.Windows.Forms.ToolStripMenuItem TypePlants;
        private System.Windows.Forms.ToolStripMenuItem Work;
        private System.Windows.Forms.ToolStripMenuItem Employee;
        private ParkDataSet parkDataSet;
        private System.Windows.Forms.BindingSource parkBindingSource;
        private ParkDataSetTableAdapters.parkTableAdapter parkTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QueryFirst;
        private System.Windows.Forms.ToolStripMenuItem QuerySecond;
        private System.Windows.Forms.ToolStripMenuItem QueryThird;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

