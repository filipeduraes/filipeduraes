namespace FilipeDuraes_Portfolio.Models;

public record ExperienceItem(
    string Company,
    string Role,
    string Period,
    string Tag,
    string Project,
    string? Link,
    string? Image,
    IReadOnlyList<string> Bullets);

public record SkillGroup(string Label, IReadOnlyList<string> Items);

public record CommunityActivity(string Text, string? Link);

public record HeroContent(
    string Greeting,
    string Role,
    string Engines,
    string Summary,
    string Cta1,
    string Cta2);

public record EducationContent(
    string Title,
    string Degree,
    string University,
    string Period,
    string CommunityLabel,
    IReadOnlyList<CommunityActivity> Activities);

public record ContactContent(string Title, string Sub, string EmailLabel);

public record PortfolioCopy(
    IReadOnlyList<string> Nav,
    IReadOnlyList<string> NavIds,
    HeroContent Hero,
    string ExpTitle,
    string SkillsTitle,
    IReadOnlyList<SkillGroup> SkillGroups,
    EducationContent Edu,
    ContactContent Contact,
    string Footer);
