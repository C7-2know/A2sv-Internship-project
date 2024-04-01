﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Common.DTOs.Book;
using Application.Responses;

namespace Application.Features.Books.Requests.Commands;

public class UpdateBookCommand : IRequest<BaseCommandResponse>
{
    public BookDTO BookDto { get; set; }
}

