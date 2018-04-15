using Machine.Specifications;

namespace pipeline.for_context
{
    public class when_setting_value
    {
        const string key = "some key";
        const string value = "fourty two";

        static context pipeline_context; 
        static string result;

        Establish context = () => pipeline_context = new context();

        Because of = () => 
        {
            pipeline_context.set(key, value);
            result = pipeline_context.get<string>(key);
        };

        It should_set_the_value = () => result.ShouldEqual(value);       
    }
}