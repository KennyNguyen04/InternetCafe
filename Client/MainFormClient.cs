﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ClientForm : Form
    {
        private ClientManager clientManager;
        private AddMoneyForm addMoneyForm;        
        private 
        const int LOGOUT = 103;
        const int MEMBERLOGIN = 102;
        int hour = 0;
        int min = 0;
        int sec = 0;
        double money = 0;
        TimeSpan total;
        TimeSpan use;
        TimeSpan remain;
        string userName = "";
        public static int check = -1;
        public static int checkOrderStatus = -1;
        ChatForm chatForm;
        public ClientForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            clientManager = new ClientManager();
            money = clientManager.clientPrice;
            ClientManager.requestServer = -1;
            timerProgram.Enabled = true;
            timerProgram.Interval = 1000;
            timerProgram.Start();
            this.Enabled = false;
            addMoneyForm = new AddMoneyForm(this, clientManager);
            chatForm = new ChatForm(this, clientManager);

        }
        public ClientForm(ClientManager x)
        {
            this.clientManager = x;
            InitializeComponent();

        }
        private void MainFormClient_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void grbUser_Enter(object sender, EventArgs e)
        {

        }

        private void timerProgram_Tick(object sender, EventArgs e)
        {
            try
            {
                if(checkOrderStatus == 1)
                {
                    checkOrderStatus = -1;
                    menu.Enabled = false;
                }
                if(checkOrderStatus == 0) {
                    checkOrderStatus= -1;
                    menu.Enabled = true;
                }
                if (ClientManager.requestServer != -1)
                {
                    
                    if (ClientManager.requestServer == MEMBERLOGIN)
                    {
                        this.Enabled = true;
                        grbUser.Text = "Người dùng: " + clientManager.userName;
                        txtCurrentMoney.Text = currencyFormat(clientManager.totalMoney);
                        userName = clientManager.userName;
                        ClientManager.requestServer = -2;
                        min = 0;
                        ClientManager.serviceFee = 0;
                        ResetTime();
                    }
                    TimeCount();
                    if (ClientManager.requestServer == -2 && ClientManager.checkAddMoney == -1)
                    {
                        use = TimeSpan.Parse(txtUsedTime.Text.ToString());
                        double remainingMoney = clientManager.totalMoney - money;
                        txtRemainingMoney.Text = currencyFormat(remainingMoney);
                        txtUseTimeFee.Text = "0";
                        clientManager.updateMoney(userName, Math.Round(remainingMoney, 0, MidpointRounding.AwayFromZero), use);
                        //txtServiceFee.Text = currencyFormat(ClientManager.serviceFee);
                    }
                    else if(ClientManager.checkAddMoney == 1)
                    {
                        ClientManager.checkAddMoney = -1;
                        txtCurrentMoney.Text = currencyFormat(clientManager.totalMoney);
                        
                    }
                    MoneyCount(txtUsedTime.Text.ToString());
                    if (ClientManager.requestServer == LOGOUT)
                    {
                        ClientManager.requestServer = -1;
                        ClientManager.serviceFee = 0;
                        timerProgram.Start();
                        txtCurrentMoney.Clear();
                        txtRemainingMoney.Clear();
                        //txtServiceFee.Clear();
                        txtUsedTime.Clear();
                        txtUseTimeFee.Clear();
                        grbUser.Text = "Username";
                        MessageBox.Show("Số tiền trong tài khoản quý khách đã hết.\nVui lòng nạp thêm tiền để tiếp tục", "Thông báo" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        clientManager.LogoutMember(userName);
                    }
                    if(ClientManager.message == "Force Logout")
                    {
                        ClientManager.message = "";
                        timerProgram.Start();
                        txtCurrentMoney.Clear();
                        txtRemainingMoney.Clear();
                        //txtServiceFee.Clear();
                        txtUsedTime.Clear();
                        txtUseTimeFee.Clear();
                        grbUser.Text = "Username";
                        ClientManager.requestServer = -1;
                        clientManager.LogoutMember(userName);
                        
                    }
                }
            }catch{
                Application.Exit();
            }
        }
        private void ResetTime()
        {
            min = 0;
            sec = 0;
            hour = 0;
            money = 0;
        }

        private void MoneyCount(string useTime)
        {
            // Chuyển đổi thời gian sử dụng sang phút
            TimeSpan timeUsed = TimeSpan.ParseExact(useTime, @"hh\:mm", CultureInfo.InvariantCulture);
            double minutesUsed = timeUsed.TotalMinutes;

            // Tính phí sử dụng dựa trên số phút đã sử dụng
            money = (clientManager.clientPrice / 60) * minutesUsed;

            // Cập nhật giá trị vào giao diện người dùng
            txtUseTimeFee.Text = currencyFormat(money);
        }


        private int ChangeUseTimeToMinutes(string useTime)
        {
            TimeSpan timeUsed = TimeSpan.ParseExact(useTime, @"hh\:mm", CultureInfo.InvariantCulture);
            return (int)timeUsed.TotalMinutes;
        }

        private void TimeCount()
        {
            // Cập nhật giao diện hiển thị thời gian
            txtUsedTime.Text = hour.ToString("D2") + ":" + min.ToString("D2");

            sec++;

            if (sec > 59)
            {
                min++;
                sec = 0;
            }

            if (min > 59)
            {
                hour++;
                min = 0;
            }

            if (hour > 99)
            {
                timerProgram.Stop();
                timerProgram.Enabled = true;
            }

            // Tính chi phí sau mỗi giây, phút, giờ
            MoneyCount(txtUsedTime.Text.ToString());
        }


        private void pnlLogout_Click(object sender, EventArgs e)
        {
            
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn đăng xuất.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                timerProgram.Start();
                txtCurrentMoney.Clear();
                txtRemainingMoney.Clear();
                //txtServiceFee.Clear();
                txtUsedTime.Clear();
                txtUseTimeFee.Clear();
                grbUser.Text = "Username";
                ClientManager.requestServer = -1;
                clientManager.LogoutMember(userName);
            }
        }

        private double RoundToThousand(double value)
        {
            return Math.Floor(value / 1000) * 1000;
        }

        private string currencyFormat(double money)
        {
            double roundedMoney = RoundToThousand(money);
            return string.Format(new CultureInfo("en-US"), "{0:N0}", roundedMoney); // Định dạng với dấu phân cách hàng nghìn
        }




        private void chat_Click(object sender, EventArgs e)
        {
            chatForm.Show();
        }

        private void addMoney_Click(object sender, EventArgs e)
        {
            if(check == 1)
            {
                check = -1;
                addMoneyForm.ShowDialog();
            }
            else
            {
                addMoneyForm = new AddMoneyForm(this, clientManager);
                addMoneyForm.ShowDialog();
            }
            
        }

        private void menu_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm(this, clientManager);
            menuForm.ShowDialog();
        }

        private void changePass_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(this, this.clientManager);
            changePasswordForm.ShowDialog();
        }

        private void txtCurrentMoney_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRemainingMoney_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
