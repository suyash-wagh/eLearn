﻿using MediatR;

namespace Infrastructure.Base.CQRS;

public interface IQuery<out TResponse> : IRequest<TResponse> 
    where TResponse : notnull
{
}
