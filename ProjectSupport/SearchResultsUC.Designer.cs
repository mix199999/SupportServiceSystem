using System.Windows.Forms;

namespace ProjectSupport
{
    partial class SearchResultsUC
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
            this.resultsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // resultsFlowPanel
            // 
            this.resultsFlowPanel.AutoScroll = true;
            this.resultsFlowPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.resultsFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.resultsFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.resultsFlowPanel.Name = "resultsFlowPanel";
            this.resultsFlowPanel.Size = new System.Drawing.Size(1021, 629);
            this.resultsFlowPanel.TabIndex = 2;
            this.resultsFlowPanel.WrapContents = false;
            this.resultsFlowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.resultsFlowPanel_Paint);
            // 
            // SearchResultsUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.resultsFlowPanel);
            this.MaximumSize = new System.Drawing.Size(1021, 629);
            this.Name = "SearchResultsUC";
            this.Size = new System.Drawing.Size(1021, 629);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel resultsFlowPanel;

        public FlowLayoutPanel ResultsFlowPanel { get => resultsFlowPanel; set => resultsFlowPanel = value; }
    }
}
