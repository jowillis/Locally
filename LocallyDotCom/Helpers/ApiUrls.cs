using System;

namespace LocallyDotCom.Helpers
{
    public static class ApiUrls
    {
        public static Uri Base { get; } = new Uri("http://www.locally.com/api/v1/", UriKind.Absolute);

        public static Uri Brands { get; } = new Uri("brands", UriKind.Relative);

        public static Uri Catalog { get; } = new Uri("catalog", UriKind.Relative);

        public static Uri Categories { get; } = new Uri("taxonomy", UriKind.Relative);
    }
}
