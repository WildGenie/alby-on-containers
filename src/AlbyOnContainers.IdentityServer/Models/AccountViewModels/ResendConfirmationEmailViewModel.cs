﻿using System.ComponentModel.DataAnnotations;

namespace IdentityServer.Models.AccountViewModels
{
    public class ResendConfirmationEmailViewModel
    {
        [Required, EmailAddress] public string Email { get; set; }
        public string ReturnUrl { get; set; }
    }
}