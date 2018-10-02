// VBConversions Note: VB project level imports
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Linq;
using System;
using System.Collections;
using System.Xml.Linq;
using System.Windows.Forms;
// End of VB project level imports


namespace HBRS
{
    [global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class frmDiscount : System.Windows.Forms.Form
    {

        //Form overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        //Required by the Windows Form Designer
        private System.ComponentModel.Container components = null;

        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.lvlDiscount = new System.Windows.Forms.ListView();
            base.Load += new System.EventHandler(frmDiscount_Load);
            this.lvlDiscount.DoubleClick += new System.EventHandler(this.lvlDiscount_DoubleClick);
            this.ColumnHeader1 = (System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader());
            this.ColumnHeader2 = (System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader());
            this.ColumnHeader3 = (System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader());
            this.txtType = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            this.Label1 = new System.Windows.Forms.Label();
            this.bttnSave = new System.Windows.Forms.Button();
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            this.bttnCancel = new System.Windows.Forms.Button();
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            this.Label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            //lvlDiscount
            //
            this.lvlDiscount.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.ColumnHeader1, this.ColumnHeader2, this.ColumnHeader3 });
            this.lvlDiscount.FullRowSelect = true;
            this.lvlDiscount.GridLines = true;
            this.lvlDiscount.Location = new System.Drawing.Point(305, 59);
            this.lvlDiscount.Name = "lvlDiscount";
            this.lvlDiscount.Size = new System.Drawing.Size(201, 159);
            this.lvlDiscount.TabIndex = 0;
            this.lvlDiscount.UseCompatibleStateImageBehavior = false;
            this.lvlDiscount.View = System.Windows.Forms.View.Details;
            //
            //ColumnHeader1
            //
            this.ColumnHeader1.Text = "ID";
            this.ColumnHeader1.Width = 30;
            //
            //ColumnHeader2
            //
            this.ColumnHeader2.Text = "Type";
            this.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader2.Width = 100;
            //
            //ColumnHeader3
            //
            this.ColumnHeader3.Text = "Rate";
            this.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            //txtType
            //
            this.txtType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.txtType.Location = new System.Drawing.Point(138, 85);
            this.txtType.Multiline = true;
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(146, 25);
            this.txtType.TabIndex = 76;
            this.txtType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            //Label4
            //
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.Label4.Location = new System.Drawing.Point(12, 90);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(95, 16);
            this.Label4.TabIndex = 77;
            this.Label4.Text = "Discount Type";
            //
            //txtRate
            //
            this.txtRate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.txtRate.Location = new System.Drawing.Point(138, 116);
            this.txtRate.Multiline = true;
            this.txtRate.Name = "txtRate";
            this.txtRate.ReadOnly = true;
            this.txtRate.Size = new System.Drawing.Size(66, 25);
            this.txtRate.TabIndex = 78;
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            //Label1
            //
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)(9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.Label1.Location = new System.Drawing.Point(12, 121);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(115, 16);
            this.Label1.TabIndex = 79;
            this.Label1.Text = "Discount Rate (%)";
            //
            //bttnSave
            //
            this.bttnSave.Location = new System.Drawing.Point(108, 174);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(85, 29);
            this.bttnSave.TabIndex = 80;
            this.bttnSave.Text = "&Save";
            this.bttnSave.UseVisualStyleBackColor = true;
            //
            //bttnCancel
            //
            this.bttnCancel.Location = new System.Drawing.Point(199, 174);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(85, 29);
            this.bttnCancel.TabIndex = 81;
            this.bttnCancel.Text = "&Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            //
            //Label2
            //
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)(14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.Label2.Location = new System.Drawing.Point(12, 21);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(101, 24);
            this.Label2.TabIndex = 82;
            this.Label2.Text = "Discounts";
            //
            //frmDiscount
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF((float)(6.0F), (float)(13.0F));
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 237);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.lvlDiscount);
            this.Name = "frmDiscount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal System.Windows.Forms.ListView lvlDiscount;
        internal System.Windows.Forms.TextBox txtType;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtRate;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.Button bttnSave;
        internal System.Windows.Forms.Button bttnCancel;
        internal System.Windows.Forms.Label Label2;
    }

}
