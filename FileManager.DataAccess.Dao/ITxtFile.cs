﻿using FileManager.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.DataAccess.Dao
{
    public interface ITxtFile
    {
        Student WriteTxt(Student student);
        string ReadTxt();
    }
}
