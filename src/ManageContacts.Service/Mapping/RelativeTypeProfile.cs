using AutoMapper;
using ManageContacts.Entity.Abstractions.Paginations;
using ManageContacts.Entity.Entities;
using ManageContacts.Model.Abstractions.Paginations;
using ManageContacts.Model.Models.RelativeTypes;

namespace ManageContacts.Service.Mapping;

public class RelativeTypeProfile : Profile
{
    public RelativeTypeProfile()
    {
        CreateMap<RelativeType, RelativeTypeModel>();
    }
}