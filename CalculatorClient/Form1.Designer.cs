namespace CalculatorClient
{
   partial class Form1
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
         this.btnPlus = new System.Windows.Forms.Button();
         this.btnMinus = new System.Windows.Forms.Button();
         this.btnTimes = new System.Windows.Forms.Button();
         this.btnDivide = new System.Windows.Forms.Button();
         this.txtInput = new System.Windows.Forms.TextBox();
         this.btnClear = new System.Windows.Forms.Button();
         this.btnEquals = new System.Windows.Forms.Button();
         this.lblAnswer = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // btnPlus
         // 
         this.btnPlus.Location = new System.Drawing.Point(231, 49);
         this.btnPlus.Name = "btnPlus";
         this.btnPlus.Size = new System.Drawing.Size(75, 23);
         this.btnPlus.TabIndex = 0;
         this.btnPlus.Text = "+";
         this.btnPlus.UseVisualStyleBackColor = true;
         this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
         // 
         // btnMinus
         // 
         this.btnMinus.Location = new System.Drawing.Point(231, 78);
         this.btnMinus.Name = "btnMinus";
         this.btnMinus.Size = new System.Drawing.Size(75, 23);
         this.btnMinus.TabIndex = 1;
         this.btnMinus.Text = "-";
         this.btnMinus.UseVisualStyleBackColor = true;
         this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
         // 
         // btnTimes
         // 
         this.btnTimes.Location = new System.Drawing.Point(231, 107);
         this.btnTimes.Name = "btnTimes";
         this.btnTimes.Size = new System.Drawing.Size(75, 23);
         this.btnTimes.TabIndex = 2;
         this.btnTimes.Text = "*";
         this.btnTimes.UseVisualStyleBackColor = true;
         this.btnTimes.Click += new System.EventHandler(this.btnTimes_Click);
         // 
         // btnDivide
         // 
         this.btnDivide.Location = new System.Drawing.Point(231, 136);
         this.btnDivide.Name = "btnDivide";
         this.btnDivide.Size = new System.Drawing.Size(75, 23);
         this.btnDivide.TabIndex = 3;
         this.btnDivide.Text = "/";
         this.btnDivide.UseVisualStyleBackColor = true;
         this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
         // 
         // txtInput
         // 
         this.txtInput.Location = new System.Drawing.Point(63, 65);
         this.txtInput.Name = "txtInput";
         this.txtInput.Size = new System.Drawing.Size(100, 20);
         this.txtInput.TabIndex = 4;
         // 
         // btnClear
         // 
         this.btnClear.Location = new System.Drawing.Point(231, 12);
         this.btnClear.Name = "btnClear";
         this.btnClear.Size = new System.Drawing.Size(75, 23);
         this.btnClear.TabIndex = 5;
         this.btnClear.Text = "C";
         this.btnClear.UseVisualStyleBackColor = true;
         this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
         // 
         // btnEquals
         // 
         this.btnEquals.Location = new System.Drawing.Point(339, 91);
         this.btnEquals.Name = "btnEquals";
         this.btnEquals.Size = new System.Drawing.Size(75, 23);
         this.btnEquals.TabIndex = 6;
         this.btnEquals.Text = "=";
         this.btnEquals.UseVisualStyleBackColor = true;
         this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
         // 
         // lblAnswer
         // 
         this.lblAnswer.AutoSize = true;
         this.lblAnswer.Location = new System.Drawing.Point(438, 97);
         this.lblAnswer.Name = "lblAnswer";
         this.lblAnswer.Size = new System.Drawing.Size(42, 13);
         this.lblAnswer.TabIndex = 7;
         this.lblAnswer.Text = "Answer";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(547, 191);
         this.Controls.Add(this.lblAnswer);
         this.Controls.Add(this.btnEquals);
         this.Controls.Add(this.btnClear);
         this.Controls.Add(this.txtInput);
         this.Controls.Add(this.btnDivide);
         this.Controls.Add(this.btnTimes);
         this.Controls.Add(this.btnMinus);
         this.Controls.Add(this.btnPlus);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnPlus;
      private System.Windows.Forms.Button btnMinus;
      private System.Windows.Forms.Button btnTimes;
      private System.Windows.Forms.Button btnDivide;
      private System.Windows.Forms.TextBox txtInput;
      private System.Windows.Forms.Button btnClear;
      private System.Windows.Forms.Button btnEquals;
      private System.Windows.Forms.Label lblAnswer;
   }
}

