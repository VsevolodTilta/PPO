namespace WindowsFormsApp4
{
	partial class FormAdd
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
			this.maskIndex = new System.Windows.Forms.MaskedTextBox();
			this.LbInd = new System.Windows.Forms.Label();
			this.LbName = new System.Windows.Forms.Label();
			this.LbCountry = new System.Windows.Forms.Label();
			this.LbPrice = new System.Windows.Forms.Label();
			this.lbAmount = new System.Windows.Forms.Label();
			this.labelStrength = new System.Windows.Forms.Label();
			this.textName = new System.Windows.Forms.TextBox();
			this.textCountry = new System.Windows.Forms.TextBox();
			this.textStength = new System.Windows.Forms.TextBox();
			this.textPrice = new System.Windows.Forms.TextBox();
			this.textAmount = new System.Windows.Forms.TextBox();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.btChange = new System.Windows.Forms.Button();
			this.btSearch = new System.Windows.Forms.Button();
			this.toolGGW = new System.Windows.Forms.ToolStrip();
			this.toolName = new System.Windows.Forms.ToolStripLabel();
			this.toolSecond = new System.Windows.Forms.ToolStripSeparator();
			this.toolGroup = new System.Windows.Forms.ToolStripLabel();
			this.panelMain = new System.Windows.Forms.Panel();
			this.toolGGW.SuspendLayout();
			this.panelMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// maskIndex
			// 
			this.maskIndex.Location = new System.Drawing.Point(154, 53);
			this.maskIndex.Mask = "00000";
			this.maskIndex.Name = "maskIndex";
			this.maskIndex.PromptChar = ' ';
			this.maskIndex.Size = new System.Drawing.Size(77, 20);
			this.maskIndex.TabIndex = 0;
			// 
			// LbInd
			// 
			this.LbInd.AutoSize = true;
			this.LbInd.BackColor = System.Drawing.Color.AliceBlue;
			this.LbInd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LbInd.Location = new System.Drawing.Point(20, 52);
			this.LbInd.Name = "LbInd";
			this.LbInd.Size = new System.Drawing.Size(128, 18);
			this.LbInd.TabIndex = 3;
			this.LbInd.Text = "Индекс продукта";
			// 
			// LbName
			// 
			this.LbName.AutoSize = true;
			this.LbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LbName.Location = new System.Drawing.Point(36, 89);
			this.LbName.Name = "LbName";
			this.LbName.Size = new System.Drawing.Size(112, 18);
			this.LbName.TabIndex = 5;
			this.LbName.Text = "Марка напитка";
			// 
			// LbCountry
			// 
			this.LbCountry.AutoSize = true;
			this.LbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LbCountry.Location = new System.Drawing.Point(37, 129);
			this.LbCountry.Name = "LbCountry";
			this.LbCountry.Size = new System.Drawing.Size(111, 18);
			this.LbCountry.TabIndex = 7;
			this.LbCountry.Text = "Страна произв";
			// 
			// LbPrice
			// 
			this.LbPrice.AutoSize = true;
			this.LbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LbPrice.Location = new System.Drawing.Point(105, 206);
			this.LbPrice.Name = "LbPrice";
			this.LbPrice.Size = new System.Drawing.Size(43, 18);
			this.LbPrice.TabIndex = 8;
			this.LbPrice.Text = "Цена";
			// 
			// lbAmount
			// 
			this.lbAmount.AutoSize = true;
			this.lbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbAmount.Location = new System.Drawing.Point(56, 249);
			this.lbAmount.Name = "lbAmount";
			this.lbAmount.Size = new System.Drawing.Size(92, 18);
			this.lbAmount.TabIndex = 9;
			this.lbAmount.Text = "Количество";
			// 
			// labelStrength
			// 
			this.labelStrength.AutoSize = true;
			this.labelStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelStrength.Location = new System.Drawing.Point(7, 167);
			this.labelStrength.Name = "labelStrength";
			this.labelStrength.Size = new System.Drawing.Size(141, 18);
			this.labelStrength.TabIndex = 11;
			this.labelStrength.Text = "Крепкость напитка";
			// 
			// textName
			// 
			this.textName.Location = new System.Drawing.Point(154, 90);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(77, 20);
			this.textName.TabIndex = 12;
			this.textName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textName_KeyPress);
			// 
			// textCountry
			// 
			this.textCountry.Location = new System.Drawing.Point(154, 130);
			this.textCountry.Name = "textCountry";
			this.textCountry.Size = new System.Drawing.Size(77, 20);
			this.textCountry.TabIndex = 13;
			this.textCountry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCountry_KeyPress_1);
			// 
			// textStength
			// 
			this.textStength.Location = new System.Drawing.Point(154, 168);
			this.textStength.Name = "textStength";
			this.textStength.Size = new System.Drawing.Size(77, 20);
			this.textStength.TabIndex = 14;
			// 
			// textPrice
			// 
			this.textPrice.Location = new System.Drawing.Point(154, 207);
			this.textPrice.Name = "textPrice";
			this.textPrice.Size = new System.Drawing.Size(77, 20);
			this.textPrice.TabIndex = 15;
			this.textPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPrice_KeyPress);
			// 
			// textAmount
			// 
			this.textAmount.Location = new System.Drawing.Point(154, 250);
			this.textAmount.Name = "textAmount";
			this.textAmount.Size = new System.Drawing.Size(77, 20);
			this.textAmount.TabIndex = 16;
			this.textAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAmount_KeyPress);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAdd.Location = new System.Drawing.Point(48, 289);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(101, 33);
			this.buttonAdd.TabIndex = 17;
			this.buttonAdd.Text = "Добавить";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.UseWaitCursor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// btChange
			// 
			this.btChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btChange.Location = new System.Drawing.Point(168, 289);
			this.btChange.Name = "btChange";
			this.btChange.Size = new System.Drawing.Size(103, 33);
			this.btChange.TabIndex = 18;
			this.btChange.Text = "Изменить";
			this.btChange.UseVisualStyleBackColor = true;
			this.btChange.Click += new System.EventHandler(this.btChange_Click);
			// 
			// btSearch
			// 
			this.btSearch.Location = new System.Drawing.Point(241, 51);
			this.btSearch.Name = "btSearch";
			this.btSearch.Size = new System.Drawing.Size(75, 23);
			this.btSearch.TabIndex = 19;
			this.btSearch.Text = "Найти";
			this.btSearch.UseVisualStyleBackColor = true;
			this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
			// 
			// toolGGW
			// 
			this.toolGGW.BackColor = System.Drawing.Color.LightGreen;
			this.toolGGW.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolName,
            this.toolSecond,
            this.toolGroup});
			this.toolGGW.Location = new System.Drawing.Point(0, 0);
			this.toolGGW.Name = "toolGGW";
			this.toolGGW.Size = new System.Drawing.Size(336, 25);
			this.toolGGW.TabIndex = 20;
			this.toolGGW.Text = "toolStrip1";
			// 
			// toolName
			// 
			this.toolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolName.Name = "toolName";
			this.toolName.Size = new System.Drawing.Size(83, 22);
			this.toolName.Text = "Никонов В.Н.";
			// 
			// toolSecond
			// 
			this.toolSecond.Name = "toolSecond";
			this.toolSecond.Size = new System.Drawing.Size(6, 25);
			// 
			// toolGroup
			// 
			this.toolGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.toolGroup.Name = "toolGroup";
			this.toolGroup.Size = new System.Drawing.Size(62, 22);
			this.toolGroup.Text = "ПКсп-117";
			// 
			// panelMain
			// 
			this.panelMain.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.panelMain.Controls.Add(this.textStength);
			this.panelMain.Controls.Add(this.buttonAdd);
			this.panelMain.Controls.Add(this.btChange);
			this.panelMain.Controls.Add(this.btSearch);
			this.panelMain.Controls.Add(this.labelStrength);
			this.panelMain.Controls.Add(this.lbAmount);
			this.panelMain.Controls.Add(this.textAmount);
			this.panelMain.Controls.Add(this.LbPrice);
			this.panelMain.Controls.Add(this.LbCountry);
			this.panelMain.Controls.Add(this.LbName);
			this.panelMain.Controls.Add(this.textPrice);
			this.panelMain.Controls.Add(this.LbInd);
			this.panelMain.Controls.Add(this.textCountry);
			this.panelMain.Controls.Add(this.textName);
			this.panelMain.Controls.Add(this.maskIndex);
			this.panelMain.Location = new System.Drawing.Point(6, 0);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(339, 338);
			this.panelMain.TabIndex = 21;
			// 
			// FormAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(336, 336);
			this.Controls.Add(this.toolGGW);
			this.Controls.Add(this.panelMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "FormAdd";
			this.ShowIcon = false;
			this.Text = "Добавление изменение";
			this.toolGGW.ResumeLayout(false);
			this.toolGGW.PerformLayout();
			this.panelMain.ResumeLayout(false);
			this.panelMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MaskedTextBox maskIndex;
		private System.Windows.Forms.Label LbInd;
		private System.Windows.Forms.Label LbName;
		private System.Windows.Forms.Label LbCountry;
		private System.Windows.Forms.Label LbPrice;
		private System.Windows.Forms.Label lbAmount;
		private System.Windows.Forms.Label labelStrength;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.TextBox textCountry;
		private System.Windows.Forms.TextBox textStength;
		private System.Windows.Forms.TextBox textPrice;
		private System.Windows.Forms.TextBox textAmount;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button btChange;
		private System.Windows.Forms.Button btSearch;
		private System.Windows.Forms.ToolStrip toolGGW;
		private System.Windows.Forms.ToolStripLabel toolName;
		private System.Windows.Forms.ToolStripSeparator toolSecond;
		private System.Windows.Forms.ToolStripLabel toolGroup;
		private System.Windows.Forms.Panel panelMain;
	}
}