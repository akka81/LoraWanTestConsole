namespace Reti_LoRa_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.turn_on_led_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.turn_off_led_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.light_value_label = new System.Windows.Forms.Label();
            this.set_delta_button = new System.Windows.Forms.Button();
            this.light_delta_control = new System.Windows.Forms.NumericUpDown();
            this.trigger_buzzer_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.device_status_label = new System.Windows.Forms.Label();
            this.blick_led = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.light_delta_control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "LoRa Application";
            // 
            // turn_on_led_button
            // 
            this.turn_on_led_button.Location = new System.Drawing.Point(67, 302);
            this.turn_on_led_button.Name = "turn_on_led_button";
            this.turn_on_led_button.Size = new System.Drawing.Size(75, 32);
            this.turn_on_led_button.TabIndex = 1;
            this.turn_on_led_button.Text = "Turn On";
            this.turn_on_led_button.UseVisualStyleBackColor = true;
            this.turn_on_led_button.Click += new System.EventHandler(this.turn_on_led_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "LED";
            // 
            // turn_off_led_button
            // 
            this.turn_off_led_button.Location = new System.Drawing.Point(67, 340);
            this.turn_off_led_button.Name = "turn_off_led_button";
            this.turn_off_led_button.Size = new System.Drawing.Size(75, 32);
            this.turn_off_led_button.TabIndex = 3;
            this.turn_off_led_button.Text = "Turn Off";
            this.turn_off_led_button.UseVisualStyleBackColor = true;
            this.turn_off_led_button.Click += new System.EventHandler(this.turn_off_led_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(323, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "LIGHT SENSOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(616, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "BUZZER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Light value:";
            // 
            // light_value_label
            // 
            this.light_value_label.AutoSize = true;
            this.light_value_label.Location = new System.Drawing.Point(402, 330);
            this.light_value_label.Name = "light_value_label";
            this.light_value_label.Size = new System.Drawing.Size(56, 17);
            this.light_value_label.TabIndex = 7;
            this.light_value_label.Text = "123456";
            // 
            // set_delta_button
            // 
            this.set_delta_button.Location = new System.Drawing.Point(384, 368);
            this.set_delta_button.Name = "set_delta_button";
            this.set_delta_button.Size = new System.Drawing.Size(118, 32);
            this.set_delta_button.TabIndex = 8;
            this.set_delta_button.Text = "Set Treshold";
            this.set_delta_button.UseVisualStyleBackColor = true;
            this.set_delta_button.Click += new System.EventHandler(this.set_delta_button_Click);
            // 
            // light_delta_control
            // 
            this.light_delta_control.Location = new System.Drawing.Point(276, 374);
            this.light_delta_control.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.light_delta_control.Name = "light_delta_control";
            this.light_delta_control.Size = new System.Drawing.Size(99, 22);
            this.light_delta_control.TabIndex = 10;
            this.light_delta_control.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // trigger_buzzer_button
            // 
            this.trigger_buzzer_button.Location = new System.Drawing.Point(621, 322);
            this.trigger_buzzer_button.Name = "trigger_buzzer_button";
            this.trigger_buzzer_button.Size = new System.Drawing.Size(75, 32);
            this.trigger_buzzer_button.TabIndex = 11;
            this.trigger_buzzer_button.Text = "Trigger";
            this.trigger_buzzer_button.UseVisualStyleBackColor = true;
            this.trigger_buzzer_button.Click += new System.EventHandler(this.trigger_buzzer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(40, 155);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(328, 155);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 114);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(596, 155);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(130, 114);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(681, 62);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(89, 61);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(671, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Device Status:";
            // 
            // device_status_label
            // 
            this.device_status_label.AutoSize = true;
            this.device_status_label.Location = new System.Drawing.Point(694, 29);
            this.device_status_label.Name = "device_status_label";
            this.device_status_label.Size = new System.Drawing.Size(76, 17);
            this.device_status_label.TabIndex = 19;
            this.device_status_label.Text = "Connected";
            // 
            // blick_led
            // 
            this.blick_led.Location = new System.Drawing.Point(67, 378);
            this.blick_led.Name = "blick_led";
            this.blick_led.Size = new System.Drawing.Size(75, 32);
            this.blick_led.TabIndex = 20;
            this.blick_led.Text = "Blink";
            this.blick_led.UseVisualStyleBackColor = true;
            this.blick_led.Click += new System.EventHandler(this.blick_led_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 433);
            this.Controls.Add(this.blick_led);
            this.Controls.Add(this.device_status_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.trigger_buzzer_button);
            this.Controls.Add(this.light_delta_control);
            this.Controls.Add(this.set_delta_button);
            this.Controls.Add(this.light_value_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.turn_off_led_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.turn_on_led_button);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Reti - LoRa Application";
            ((System.ComponentModel.ISupportInitialize)(this.light_delta_control)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button turn_on_led_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button turn_off_led_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label light_value_label;
        private System.Windows.Forms.Button set_delta_button;
        private System.Windows.Forms.NumericUpDown light_delta_control;
        private System.Windows.Forms.Button trigger_buzzer_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label device_status_label;
        private System.Windows.Forms.Button blick_led;
    }
}

