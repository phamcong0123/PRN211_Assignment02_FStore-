﻿using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmAddMember : Form
    {
        public frmAddMember()
        {
            InitializeComponent();
        }
        private bool isAdmin;
        private IMemberRepository memberRepository;
        public bool InsertOrUpdate { get; set; }
        public MemberObject memberInfo { get; set; }
        public bool IsAdmin { set => isAdmin = value; }
        public IMemberRepository MemberRepository { get => memberRepository; set => memberRepository = value; }

        private void btnReset_Click(object sender, EventArgs e)
        {           
            txtMemberName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtCity.Clear();
            txtCountry.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String memberName = txtMemberName.Text;
            String email = txtEmail.Text;
            String password = txtPassword.Text;
            String city = txtCity.Text;
            String country = txtCountry.Text;
            bool Admin = cbIsAdmin.Checked;
            MemberObject member = new MemberObject
            {
                MemberID = int.Parse(txtMemberID.Text),
                MemberName = memberName,
                Email = email,
                Password = password,
                City = city,
                Country = country,
                Admin = Admin
            };
            if (btnAdd.Text.Equals("Add"))
            {
                MemberRepository.AddMember(member);
            }
            else
            {
                MemberRepository.UpdateMember(member);
            }
        }
        private bool validateEmailPattern(String testEmail)
        {
            try
            {
                var emailAddress = new MailAddress(testEmail.Trim());
            }
            catch
            {
                return false;
            }
            return true;
        }
        private bool validateCharacterString(String text)
        {
            String regex = @"^[a-zA-Z\s]+$";
            return Regex.IsMatch(text, regex);
        }      
        private void frmAdd_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            txtMemberID.Text = (memberRepository.GetProperNewID()+1).ToString();
            if (!InsertOrUpdate)
            {
                this.Text = "Update member";
                txtMemberID.Text = memberInfo.MemberID.ToString();
                txtMemberName.Text = memberInfo.MemberName;
                txtEmail.Text = memberInfo.Email;
                txtPassword.Text = memberInfo.Password;
                txtCity.Text = memberInfo.City;
                txtCountry.Text = memberInfo.Country;
                cbIsAdmin.Checked = memberInfo.Admin;
                cbIsAdmin.Enabled = false;
                btnAdd.Text = "Update";
            }
        }
        private void validateForm()
        {
            String memberName = txtMemberName.Text;
            String email = txtEmail.Text;
            String password = txtPassword.Text;
            String city = txtCity.Text;
            String country = txtCountry.Text;
            bool enabled = true;
            if (!validateCharacterString(memberName)) enabled = false;
            if (!validateEmailPattern(email)) enabled = false;
            if (!validateCharacterString(city)) enabled = false;
            if (!validateCharacterString(country)) enabled = false;
            btnAdd.Enabled = enabled;
        }
        
        private void txtMemberName_TextChanged(object sender, EventArgs e)
        {
            validateForm();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            validateForm();
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            validateForm();
        }

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {
            validateForm();
        }

        private void txtMemberName_Validating(object sender, CancelEventArgs e)
        {
            String name = txtMemberName.Text;
            if (!validateCharacterString(name))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtMemberName, "Only allow characters and whitespace");
            }
        }
        private void txtMemberName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMemberName, "");
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtEmail, "");
        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            String email = txtEmail.Text;
            if (!validateEmailPattern(email))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Invalid email address format");
            }
        }
        private void txtCity_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtCity, "");
        }
        private void txtCity_Validating(object sender, CancelEventArgs e)
        {
            String city = txtCity.Text;
            if (!validateCharacterString(city))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCity, "Only allow characters and whitespace");
            }
        }
        private void txtCountry_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtCountry, "");
        }
        private void txtCountry_Validating(object sender, CancelEventArgs e)
        {
            String country = txtCountry.Text;
            if (!validateCharacterString(country))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCountry, "Only allow characters and whitespace");
            }
        }
    }
}
