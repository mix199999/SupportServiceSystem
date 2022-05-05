namespace ProjectSupport
{
    partial class selectSellerBuyerBar
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buyerBt = new System.Windows.Forms.Button();
            this.sellerBt = new System.Windows.Forms.Button();
            this.naviPanelSellBuy = new System.Windows.Forms.Panel();
            this.naviPanelSellBuy.SuspendLayout();
            this.SuspendLayout();
            // 
            // buyerBt
            // 
            this.buyerBt.Location = new System.Drawing.Point(23, 51);
            this.buyerBt.Name = "buyerBt";
            this.buyerBt.Size = new System.Drawing.Size(163, 88);
            this.buyerBt.TabIndex = 1;
            this.buyerBt.Text = "Buyer";
            this.buyerBt.UseVisualStyleBackColor = true;
            this.buyerBt.Click += new System.EventHandler(this.buyerBt_Click);
            // 
            // sellerBt
            // 
            this.sellerBt.Location = new System.Drawing.Point(23, 168);
            this.sellerBt.Name = "sellerBt";
            this.sellerBt.Size = new System.Drawing.Size(163, 88);
            this.sellerBt.TabIndex = 2;
            this.sellerBt.Text = "Seller";
            this.sellerBt.UseVisualStyleBackColor = true;
            this.sellerBt.Click += new System.EventHandler(this.sellerBt_Click);
            // 
            // naviPanelSellBuy
            // 
            this.naviPanelSellBuy.Controls.Add(this.buyerBt);
            this.naviPanelSellBuy.Controls.Add(this.sellerBt);
            this.naviPanelSellBuy.Location = new System.Drawing.Point(0, 0);
            this.naviPanelSellBuy.Name = "naviPanelSellBuy";
            this.naviPanelSellBuy.Size = new System.Drawing.Size(204, 326);
            this.naviPanelSellBuy.TabIndex = 7;
            // 
            // selectSellerBuyerBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.naviPanelSellBuy);
            this.Name = "selectSellerBuyerBar";
            this.Size = new System.Drawing.Size(204, 326);
            this.naviPanelSellBuy.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buyerBt;
        private System.Windows.Forms.Button sellerBt;
        private System.Windows.Forms.Panel naviPanelSellBuy;
    }
}
