namespace reinforce_game
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_level = new System.Windows.Forms.Label();
            this.txt_level_ex = new System.Windows.Forms.Label();
            this.btn_reinforce = new System.Windows.Forms.Button();
            this.btn_sell = new System.Windows.Forms.Button();
            this.btn_keep = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.txt_money_ex = new System.Windows.Forms.Label();
            this.txt_money = new System.Windows.Forms.Label();
            this.inventory = new System.Windows.Forms.ListView();
            this.txt_inventory = new System.Windows.Forms.Label();
            this.txt_rate_ex = new System.Windows.Forms.Label();
            this.txt_rate = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txt_level
            // 
            this.txt_level.AutoSize = true;
            this.txt_level.Location = new System.Drawing.Point(204, 72);
            this.txt_level.Name = "txt_level";
            this.txt_level.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_level.Size = new System.Drawing.Size(15, 15);
            this.txt_level.TabIndex = 0;
            this.txt_level.Text = "0";
            this.txt_level.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_level_ex
            // 
            this.txt_level_ex.AutoSize = true;
            this.txt_level_ex.Location = new System.Drawing.Point(47, 72);
            this.txt_level_ex.Name = "txt_level_ex";
            this.txt_level_ex.Size = new System.Drawing.Size(107, 15);
            this.txt_level_ex.TabIndex = 1;
            this.txt_level_ex.Text = "현재 장비 단계";
            // 
            // btn_reinforce
            // 
            this.btn_reinforce.Location = new System.Drawing.Point(313, 64);
            this.btn_reinforce.Name = "btn_reinforce";
            this.btn_reinforce.Size = new System.Drawing.Size(75, 23);
            this.btn_reinforce.TabIndex = 2;
            this.btn_reinforce.Text = "reinforce";
            this.btn_reinforce.UseVisualStyleBackColor = true;
            this.btn_reinforce.Click += new System.EventHandler(this.btn_reinforce_Click);
            // 
            // btn_sell
            // 
            this.btn_sell.Location = new System.Drawing.Point(313, 108);
            this.btn_sell.Name = "btn_sell";
            this.btn_sell.Size = new System.Drawing.Size(75, 23);
            this.btn_sell.TabIndex = 3;
            this.btn_sell.Text = "sell";
            this.btn_sell.UseVisualStyleBackColor = true;
            this.btn_sell.Click += new System.EventHandler(this.btn_sell_Click);
            // 
            // btn_keep
            // 
            this.btn_keep.Location = new System.Drawing.Point(313, 153);
            this.btn_keep.Name = "btn_keep";
            this.btn_keep.Size = new System.Drawing.Size(75, 23);
            this.btn_keep.TabIndex = 4;
            this.btn_keep.Text = "keep";
            this.btn_keep.UseVisualStyleBackColor = true;
            this.btn_keep.Click += new System.EventHandler(this.btn_keep_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(313, 199);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 5;
            this.btn_load.Text = "load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // txt_money_ex
            // 
            this.txt_money_ex.AutoSize = true;
            this.txt_money_ex.Location = new System.Drawing.Point(57, 203);
            this.txt_money_ex.Name = "txt_money_ex";
            this.txt_money_ex.Size = new System.Drawing.Size(51, 15);
            this.txt_money_ex.TabIndex = 6;
            this.txt_money_ex.Text = "money";
            // 
            // txt_money
            // 
            this.txt_money.AutoSize = true;
            this.txt_money.Location = new System.Drawing.Point(204, 199);
            this.txt_money.Name = "txt_money";
            this.txt_money.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_money.Size = new System.Drawing.Size(47, 15);
            this.txt_money.TabIndex = 7;
            this.txt_money.Text = "10000";
            this.txt_money.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // inventory
            // 
            this.inventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.inventory.FullRowSelect = true;
            this.inventory.GridLines = true;
            this.inventory.HideSelection = false;
            this.inventory.Location = new System.Drawing.Point(448, 47);
            this.inventory.Margin = new System.Windows.Forms.Padding(1);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(197, 334);
            this.inventory.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.inventory.TabIndex = 8;
            this.inventory.TileSize = new System.Drawing.Size(5, 5);
            this.inventory.UseCompatibleStateImageBehavior = false;
            this.inventory.View = System.Windows.Forms.View.Details;
            // 
            // txt_inventory
            // 
            this.txt_inventory.AutoSize = true;
            this.txt_inventory.Location = new System.Drawing.Point(445, 29);
            this.txt_inventory.Name = "txt_inventory";
            this.txt_inventory.Size = new System.Drawing.Size(67, 15);
            this.txt_inventory.TabIndex = 9;
            this.txt_inventory.Text = "inventory";
            // 
            // txt_rate_ex
            // 
            this.txt_rate_ex.AutoSize = true;
            this.txt_rate_ex.Location = new System.Drawing.Point(47, 116);
            this.txt_rate_ex.Name = "txt_rate_ex";
            this.txt_rate_ex.Size = new System.Drawing.Size(67, 15);
            this.txt_rate_ex.TabIndex = 10;
            this.txt_rate_ex.Text = "성공확률";
            // 
            // txt_rate
            // 
            this.txt_rate.AutoSize = true;
            this.txt_rate.Location = new System.Drawing.Point(204, 116);
            this.txt_rate.Name = "txt_rate";
            this.txt_rate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_rate.Size = new System.Drawing.Size(31, 15);
            this.txt_rate.TabIndex = 11;
            this.txt_rate.Text = "100";
            this.txt_rate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "level";
            this.columnHeader1.Width = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_rate);
            this.Controls.Add(this.txt_rate_ex);
            this.Controls.Add(this.txt_inventory);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.txt_money);
            this.Controls.Add(this.txt_money_ex);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_keep);
            this.Controls.Add(this.btn_sell);
            this.Controls.Add(this.btn_reinforce);
            this.Controls.Add(this.txt_level_ex);
            this.Controls.Add(this.txt_level);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_level;
        private System.Windows.Forms.Label txt_level_ex;
        private System.Windows.Forms.Button btn_reinforce;
        private System.Windows.Forms.Button btn_sell;
        private System.Windows.Forms.Button btn_keep;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Label txt_money_ex;
        private System.Windows.Forms.Label txt_money;
        private System.Windows.Forms.ListView inventory;
        private System.Windows.Forms.Label txt_inventory;
        private System.Windows.Forms.Label txt_rate_ex;
        private System.Windows.Forms.Label txt_rate;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

