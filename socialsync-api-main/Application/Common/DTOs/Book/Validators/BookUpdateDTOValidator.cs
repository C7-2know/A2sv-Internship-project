﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.DTOs.Book;

using Application.Common.DTOs.Book;
using Application.Contracts.Persistence;

namespace Application.Common.DTOs.Book.Validators;

public class UpdateBookDtoValidator : AbstractValidator<BookDTO>
{

    public  UpdateBookDtoValidator()
    {
        Include(new IBookDtoValidator());
    }
}

