﻿using System;
using System.Collections.Generic;

namespace ASPCoreWebAPI_CRUD.Models
{
    public partial class UserTbl
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
