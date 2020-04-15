namespace WindowsFormsApp4
{
	partial class FormMain
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.OutDisplay = new System.Windows.Forms.DataGridView();
			this.Add = new System.Windows.Forms.Button();
			this.textSave = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.BtOpen = new System.Windows.Forms.Button();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripName = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripGroup = new System.Windows.Forms.ToolStripLabel();
			this.Delete = new System.Windows.Forms.Button();
			this.textDelete = new System.Windows.Forms.TextBox();
			this.panelMain = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.OutDisplay)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// OutDisplay
			// 
			this.OutDisplay.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.OutDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.OutDisplay.Location = new System.Drawing.Point(12, 96);
			this.OutDisplay.Name = "OutDisplay";
			this.OutDisplay.ReadOnly = true;
			this.OutDisplay.Size = new System.Drawing.Size(762, 124);
			this.OutDisplay.TabIndex = 2;
			this.OutDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OutDisplay_CellContentClick);
			// 
			// Add
			// 
			this.Add.Location = new System.Drawing.Point(615, 38);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(156, 52);
			this.Add.TabIndex = 3;
			this.Add.Text = "Добавить или изменить";
			this.Add.UseVisualStyleBackColor = true;
			this.Add.Click += new System.EventHandler(this.Add_Click);
			// 
			// textSave
			// 
			this.textSave.Location = new System.Drawing.Point(431, 38);
			this.textSave.Name = "textSave";
			this.textSave.Size = new System.Drawing.Size(162, 52);
			this.textSave.TabIndex = 5;
			this.textSave.Text = "Сохранить";
			this.textSave.UseVisualStyleBackColor = true;
			this.textSave.Click += new System.EventHandler(this.textSave_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// BtOpen
			// 
			this.BtOpen.Location = new System.Drawing.Point(270, 67);
			this.BtOpen.Name = "BtOpen";
			this.BtOpen.Size = new System.Drawing.Size(119, 23);
			this.BtOpen.TabIndex = 6;
			this.BtOpen.Text = "Путь к файлу";
			this.BtOpen.UseVisualStyleBackColor = true;
			this.BtOpen.Click += new System.EventHandler(this.BtOpen_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.LightGreen;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripName,
            this.toolStripSeparator1,
            this.toolStripGroup});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(783, 25);
			this.toolStrip1.TabIndex = 7;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripName
			// 
			this.toolStripName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.toolStripName.Name = "toolStripName";
			this.toolStripName.Size = new System.Drawing.Size(83, 22);
			this.toolStripName.Text = "Никонов В.Н.";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripGroup
			// 
			this.toolStripGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.toolStripGroup.Name = "toolStripGroup";
			this.toolStripGroup.Size = new System.Drawing.Size(62, 22);
			this.toolStripGroup.Text = "ПКсп-117";
			// 
			// Delete
			// 
			this.Delete.Location = new System.Drawing.Point(12, 67);
			this.Delete.Name = "Delete";
			this.Delete.Size = new System.Drawing.Size(75, 23);
			this.Delete.TabIndex = 1;
			this.Delete.Text = "Удаление";
			this.Delete.UseVisualStyleBackColor = true;
			this.Delete.Click += new System.EventHandler(this.Delete_Click);
			// 
			// textDelete
			// 
			this.textDelete.Location = new System.Drawing.Point(93, 69);
			this.textDelete.Name = "textDelete";
			this.textDelete.Size = new System.Drawing.Size(113, 20);
			this.textDelete.TabIndex = 4;
			this.textDelete.TextChanged += new System.EventHandler(this.textDelete_TextChanged);
			// 
			// panelMain
			// 
			this.panelMain.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.panelMain.Location = new System.Drawing.Point(6, 0);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(783, 231);
			this.panelMain.TabIndex = 8;
			this.panelMain.TabStop = true;
			this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(783, 223);
			this.Controls.Add(this.textDelete);
			this.Controls.Add(this.Delete);
			this.Controls.Add(this.BtOpen);
			this.Controls.Add(this.OutDisplay);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.textSave);
			this.Controls.Add(this.Add);
			this.Controls.Add(this.panelMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "FormMain";
			this.ShowIcon = false;
			this.Text = "Курсовая";
			this.Load += new System.EventHandler(this.FormMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.OutDisplay)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DataGridView OutDisplay;
		private System.Windows.Forms.Button Add;
		private System.Windows.Forms.Button textSave;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button BtOpen;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel toolStripName;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripLabel toolStripGroup;
		private System.Windows.Forms.Button Delete;
		private System.Windows.Forms.TextBox textDelete;
		private System.Windows.Forms.Panel panelMain;
	}
}

