﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Conection_Models.Interfaces;

public interface IModelDB
{
    public int Id { get; set; }
    public string Name { get; set; }
}
