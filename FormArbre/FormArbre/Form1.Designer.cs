namespace FormArbre
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nœud1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nœud2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nœud3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Nœud4");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Nœud5");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Nœud6");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Nœud0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Nœud8");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Nœud9");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Nœud10");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Nœud11");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Nœud12");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Nœud14");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Nœud15");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Nœud16");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Nœud17");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Nœud18");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Nœud19");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Nœud20");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Nœud13", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Nœud7", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode20});
            this.testbonjour = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // testbonjour
            // 
            this.testbonjour.Location = new System.Drawing.Point(12, 12);
            this.testbonjour.Name = "testbonjour";
            treeNode1.Name = "Nœud1";
            treeNode1.Text = "Nœud1";
            treeNode2.Name = "Nœud2";
            treeNode2.Text = "Nœud2";
            treeNode3.Name = "Nœud3";
            treeNode3.Text = "Nœud3";
            treeNode4.Name = "Nœud4";
            treeNode4.Text = "Nœud4";
            treeNode5.Name = "Nœud5";
            treeNode5.Text = "Nœud5";
            treeNode6.Name = "Nœud6";
            treeNode6.Text = "Nœud6";
            treeNode7.Name = "Nœud0";
            treeNode7.Text = "Nœud0";
            treeNode8.Name = "Nœud8";
            treeNode8.Text = "Nœud8";
            treeNode9.Name = "Nœud9";
            treeNode9.Text = "Nœud9";
            treeNode10.Name = "Nœud10";
            treeNode10.Text = "Nœud10";
            treeNode11.Name = "Nœud11";
            treeNode11.Text = "Nœud11";
            treeNode12.Name = "Nœud12";
            treeNode12.Text = "Nœud12";
            treeNode13.Name = "Nœud14";
            treeNode13.Text = "Nœud14";
            treeNode14.Name = "Nœud15";
            treeNode14.Text = "Nœud15";
            treeNode15.Name = "Nœud16";
            treeNode15.Text = "Nœud16";
            treeNode16.Name = "Nœud17";
            treeNode16.Text = "Nœud17";
            treeNode17.Name = "Nœud18";
            treeNode17.Text = "Nœud18";
            treeNode18.Name = "Nœud19";
            treeNode18.Text = "Nœud19";
            treeNode19.Name = "Nœud20";
            treeNode19.Text = "Nœud20";
            treeNode20.Name = "Nœud13";
            treeNode20.Text = "Nœud13";
            treeNode21.Name = "Nœud7";
            treeNode21.Text = "Nœud7";
            this.testbonjour.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode21});
            this.testbonjour.Size = new System.Drawing.Size(361, 289);
            this.testbonjour.TabIndex = 0;
            this.testbonjour.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.testbonjour_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 313);
            this.Controls.Add(this.testbonjour);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView testbonjour;
    }
}

