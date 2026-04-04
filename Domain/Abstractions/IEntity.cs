using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Abstractions;

public interface IEntity<T>: IEntity
{
    public T Id { get; set; }
}

public interface IEntity
{

}