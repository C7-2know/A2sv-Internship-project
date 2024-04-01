﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Common.DTOs.Book;

namespace Application.Features.Books.Requests.Queries;

public class GetBookDetailRequest : IRequest<BookDTO>
{
    public int Id { get; set; }
}

