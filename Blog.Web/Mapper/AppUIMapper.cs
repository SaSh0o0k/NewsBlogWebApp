using AutoMapper;
using Blog.Web.Data;
using Blog.Web.Data.Entities;
using Blog.Web.Models.Category;
using Blog.Web.Models.Post;
using Blog.Web.Models.Tag;

namespace Blog.Web.Mapper
{
    public class AppUIMapper : Profile
    {
        //private readonly AppEFContext _context;
        public AppUIMapper(AppEFContext context)
        {
            //_context = context;

            CreateMap<CategoryEntity, CategoryItemViewModel>();
            CreateMap<TagEntity, TagItemViewModel>();
            CreateMap<PostEntity, PostItemViewModel>()
                .ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.PostTags.Select(pt => pt.Tag).ToList()));
        }
    }
}
