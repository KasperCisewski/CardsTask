namespace Cards.Domain.ActionAggregate;

public record Action(Guid Id, string Name);

public static class Actions  
{  
    public static readonly Action Action1 = new(new Guid("11111111-1111-1111-1111-111111111111"), "Action1");  
    public static readonly Action Action2 = new(new Guid("22222222-2222-2222-2222-222222222222"), "Action2");  
    public static readonly Action Action3 = new(new Guid("33333333-3333-3333-3333-333333333333"), "Action3");  
    public static readonly Action Action4 = new(new Guid("44444444-4444-4444-4444-444444444444"), "Action4");  
    public static readonly Action Action5 = new(new Guid("55555555-5555-5555-5555-555555555555"), "Action5");  
    public static readonly Action Action6 = new(new Guid("66666666-6666-6666-6666-666666666666"), "Action6");  
    public static readonly Action Action7 = new(new Guid("77777777-7777-7777-7777-777777777777"), "Action7");  
    public static readonly Action Action8 = new(new Guid("88888888-8888-8888-8888-888888888888"), "Action8");  
    public static readonly Action Action9 = new(new Guid("99999999-9999-9999-9999-999999999999"), "Action9");  
    public static readonly Action Action10 = new(new Guid("10101010-1010-1010-1010-101010101010"), "Action10");  
    public static readonly Action Action11 = new(new Guid("11111111-1111-1111-1111-111111111112"), "Action11");  
    public static readonly Action Action12 = new(new Guid("12121212-1212-1212-1212-121212121212"), "Action12");  
    public static readonly Action Action13 = new(new Guid("13131313-1313-1313-1313-131313131313"), "Action13");  
}  