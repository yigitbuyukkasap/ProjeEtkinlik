﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjeEtkinlik.Views.User
{


    public partial class UpdateInsert : AuthCheck
    {

        Proje.Etkinlik.Data.Uye uyeEntity = new Proje.Etkinlik.Data.Uye();
        Proje.Etkinlik.Repository.User userRepo = new Proje.Etkinlik.Repository.User();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var uye = (Proje.Etkinlik.Data.Uye)System.Web.HttpContext.Current.Session["User"];
                txt_adsoyad.Value = uye.AdSoyad;
                txt_telefon.Value = uye.Telefon;
                txt_email.Value = uye.Email;
                txt_sifre.Value = uye.Sifre;
            }

        }

        protected void duzenle_Click(object sender, EventArgs e)
        {
            uyeEntity.AdSoyad = txt_adsoyad.Value;
            uyeEntity.Telefon = txt_telefon.Value;
            uyeEntity.Email = txt_email.Value;
            uyeEntity.Sifre = txt_sifre.Value;

            ApiHttpRequests httpRequest = new ApiHttpRequests();
            var rp = httpRequest.HttpPutRequest("user/edituser", uyeEntity);
        }
        protected void sil_Click(object sender, EventArgs e)
        {
            string email = Session["Kullanici"].ToString();
            userRepo.UyeSil(email);
        }
    }
}