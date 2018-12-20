﻿using System;
using System.Diagnostics;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace WinFormUI
{
    public partial class FormPostSummary : Form
    {
        public Post ThePost { get; set; }

        public FormPostSummary(Post i_ThePost)
        {
            ThePost = i_ThePost;
            InitializeComponent();
        }

        private void FormPostSummary_Load(object sender, EventArgs e)
        {
            lableStatus.Text = ThePost.Message;
           
            foreach (Comment comment in ThePost.Comments)
            {
                listBoxComments.Items.Add(comment.ToString());
            }

            labelNumOfLikes.Text = ThePost.LikedBy.Count.ToString();
            dateTimePicker1.Value = new DateTime( ThePost.UpdateTime.Value.Ticks);
        }

        private void linkToPostOnFB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(ThePost.Link);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
