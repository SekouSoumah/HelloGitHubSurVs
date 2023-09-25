namespace HelloGitHubSurVs
{
    partial class HelleGitHubForm
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
            this.helloGitHubButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helloGitHubButton
            // 
            this.helloGitHubButton.Location = new System.Drawing.Point(63, 67);
            this.helloGitHubButton.Name = "helloGitHubButton";
            this.helloGitHubButton.Size = new System.Drawing.Size(115, 42);
            this.helloGitHubButton.TabIndex = 0;
            this.helloGitHubButton.Text = "Hello GitHut";
            this.helloGitHubButton.UseVisualStyleBackColor = true;
            this.helloGitHubButton.Click += new System.EventHandler(this.helloGitHubButton_Click);
            // 
            // HelleGitHubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 178);
            this.Controls.Add(this.helloGitHubButton);
            this.Name = "HelleGitHubForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GitHub et Git sur visual studio";
            this.Load += new System.EventHandler(this.HelleGitHubForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button helloGitHubButton;
    }
}

