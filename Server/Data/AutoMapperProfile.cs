namespace BaseballPipeline.Server.Data
{
    using AutoMapper;
    using BaseballPipeline.Server.Data.Entities;
    using BaseballPipeline.Shared.Models;
    using System;
    using System.Linq;

    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            this.CreateMap<TagModel, Tag>().ReverseMap();
            CreateMap<Entry, EntryModel>()
                .ForMember(dest => dest.Tags,
                   opt => opt.MapFrom(src => src.EntryTags.Select(t => new MultipleSelectorModel() { Key = t.TagId.ToString(), Value = t.Tag.Value })))
                .ForMember(dest => dest.ExistingTags,
                   opt => opt.MapFrom(src => src.EntryTags.Select(t => t.TagId)));
            CreateMap<EntryModel, Entry>()
                .ForMember(dest => dest.EntryTags,
                   opt => opt.MapFrom(src => src.Tags.Select(t => new EntryTag() { TagId = Convert.ToInt32(t.Key) })))
                .ForSourceMember(src => src.ExistingTags, opt => opt.DoNotValidate());
        }
    }
}
