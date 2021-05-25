using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CommentMetaManager>().As<ICommentMetaService>();
            builder.RegisterType<EfCommentMetaDal>().As<ICommentMetaDal>();

            builder.RegisterType<CommentManager>().As<ICommentService>();
            builder.RegisterType<EfCommentDal>().As<ICommentDal>();

            builder.RegisterType<LinkManager>().As<ILinkService>();
            builder.RegisterType<EfLinkDal>().As<ILinkDal>();

            builder.RegisterType<OptionManager>().As<IOptionService>();
            builder.RegisterType<EfOptionDal>().As<IOptionDal>();

            builder.RegisterType<PostMetaManager>().As<IPostMetaService>();
            builder.RegisterType<EfPostMetaDal>().As<IPostMetaDal>();

            builder.RegisterType<PostManager>().As<IPostService>();
            builder.RegisterType<EfPostDal>().As<IPostDal>();

            builder.RegisterType<TermMetaManager>().As<ITermMetaService>();
            builder.RegisterType<EfTermMetaDal>().As<ITermMetaDal>();

            builder.RegisterType<TermRelationshipManager>().As<ITermRelationshipService>();
            builder.RegisterType<EfTermRelationshipDal>().As<ITermRelationshipDal>();

            builder.RegisterType<TermManager>().As<ITermService>();
            builder.RegisterType<EfTermDal>().As<ITermDal>();

            builder.RegisterType<TermTaxonomyManager>().As<ITermTaxonomyService>();
            builder.RegisterType<EfTermTaxonomyDal>().As<ITermTaxonomyDal>();

            builder.RegisterType<UserMetaManager>().As<IUserMetaService>();
            builder.RegisterType<EfUserMetaDal>().As<IUserMetaDal>();

            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
