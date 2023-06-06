﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using RealEstate.Attributes;

namespace RealEstate.Models
{
    public class AgentMaster: CommonBase
    {

        #region _qe

        public int Id { get; set; }
        public int MID { get; set; }
        public int SID { get; set; }
        public string Leg { get; set; }
        public string Member_Id { get; set; }

        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name required")]
        public string Name { get; set; }

        [Display(Name = "Father Name")]
        [Required(ErrorMessage = "Father's name required")]
        public string FatherName { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "Gender required")]
        public string Gender { get; set; }

        [Display(Name = "Mobile")]
        [Required(ErrorMessage = "Mobile no required")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Enter a valid mobile no.")]
        public string Mobile { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email required")]
        public string Email { get; set; }

        [Display(Name = "Aadhar Number")]
        [Required(ErrorMessage = "Aadhar number required")]
        [RegularExpression(@"^([0-9]{12})$", ErrorMessage = "Please enter a valid aadhar number")]
        public string AdharNo { get; set; }

        [Display(Name = "PAN Number")]
        [Required(ErrorMessage = "Pan number required")]
        [RegularExpression(@"^([A-Za-z]){5}([0-9]){4}([A-Za-z]){1}$", ErrorMessage = "Please enter a valid PAN number")]
        public string PanNo { get; set; }

        [Display(Name = "Pan Number")]
        [Required(ErrorMessage = "Pan number required")]
        [DOB18Over]
        public string DOB { get; set; }

        [Display(Name = "Bank Name")]
        public string BankName { get; set; }

        [Display(Name = "Branch")]
        public string Branch { get; set; }

        [Display(Name = "IFSC Code")]
        public string IFSCCode { get; set; }

        [Display(Name = "Account Number")]
        [Required(ErrorMessage = "A/C no required")]
        [RegularExpression(@"^([0-9])$", ErrorMessage = "Enter a valid A/C number")]
        public string AccountNo { get; set; }

        [Display(Name = "Profile")]
        [RegularExpression(@"([A-Za-z0-9\s_\\.\-:])+(.png|.jpg|.jpeg)$", ErrorMessage = "Upload a valid file. It may be .jpg, .jpeg or .png type and allows only a-z, 0-9 and special character(_,.,-)")]
        public HttpPostedFileBase _profilePic { get; set; }
        public string ProfilePic { get; set; }

        [Display(Name = "Bank Copy")]
        [RegularExpression(@"([A-Za-z0-9\s_\\.\-:])+(.png|.jpg|.jpeg)$", ErrorMessage = "Upload a valid file. It may be .jpg, .jpeg or .png type and allows only a-z, 0-9 and special character(_,.,-)")]
        public HttpPostedFileBase _bankCopy { get; set; }
        public string BankCopy { get; set; }

        [Display(Name = "Aadhar Front Copy")]
        [RegularExpression(@"([A-Za-z0-9\s_\\.\-:])+(.png|.jpg|.jpeg)$", ErrorMessage = "Upload a valid file. It may be .jpg, .jpeg or .png type and allows only a-z, 0-9 and special character(_,.,-)")]
        public HttpPostedFileBase _adharFrontCopy { get; set; }
        public string AdharFrontCopy { get; set; }

        [Display(Name = "Aadhar Back Copy")]
        [RegularExpression(@"([A-Za-z0-9\s_\\.\-:])+(.png|.jpg|.jpeg)$", ErrorMessage = "Upload a valid file. It may be .jpg, .jpeg or .png type and allows only a-z, 0-9 and special character(_,.,-)")]
        public HttpPostedFileBase _adharBackCopy { get; set; }
        public string AdharBackCopy { get; set; }

        [Display(Name = "PAN Copy")]
        [RegularExpression(@"([A-Za-z0-9\s_\\.\-:])+(.png|.jpg|.jpeg)$", ErrorMessage = "Upload a valid file. It may be .jpg, .jpeg or .png type and allows only a-z, 0-9 and special character(_,.,-)")]
        public HttpPostedFileBase _panCopy { get; set; }
        public string PanCopy { get; set; }

        [Display(Name = "KYC Status")]
        public string KYC_Status { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }
        public int Rank_Id { get; set; }
        public DataTable dt { get; set; }

        #endregion _qe

    }
}