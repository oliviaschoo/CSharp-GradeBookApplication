﻿namespace GradeBook.GradeBooks
using System;

{
    public class StandardGradeBook : BaseGradeBook
{
    public StandardGradeBook(string name) : base(name)
    {
        Type = Enums.GradeBookType.Standard
        }
}
}