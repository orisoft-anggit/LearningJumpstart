﻿using System;
namespace LearningJumpstart.Dtos.Character
{
    public class UserRegisterDto
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public UserRegisterDto()
        {
        }
    }
}

