using FilipeDuraes_Portfolio.Models;

namespace FilipeDuraes_Portfolio.Data;

public static class PortfolioData
{
    public static IReadOnlyDictionary<string, IReadOnlyList<ExperienceItem>> ExperienceItems { get; } =
        new Dictionary<string, IReadOnlyList<ExperienceItem>>
        {
            ["en"] =
            [
                new(
                    "Globant",
                    "Game Engineer",
                    "Jan 2026 — Present",
                    "AAA · Live-Service",
                    "The Sims",
                    "https://www.ea.com/games/the-sims",
                    null,
                    [
                        "Contributing to The Sims as part of a Globant outsourcing team supporting Electronic Arts (EA).",
                        "Developing gameplay features using Python, C++, and data-driven tuning systems within a large-scale proprietary AAA engine.",
                        "Working within a mature 10+ year-old codebase — a live-service game with 85M+ players.",
                    ]),
                new(
                    "Big Moxi Games",
                    "Unreal Game Engineer",
                    "Mar 2024 — Dec 2025",
                    "Unreal Engine 5",
                    "Wardens Rising / Exo GP",
                    "https://www.bigmoxigames.com",
                    null,
                    [
                        "Optimized large-scale enemy horde AI in Wardens Rising, reducing frame time by 20% in real-time combat.",
                        "Implemented gameplay abilities and attacks using Unreal Gameplay Ability System (GAS).",
                        "Established scalable data-driven UI architecture using Common UI and MVVM — full main menu overhaul for Exo GP.",
                        "Session management with API integrations across Epic Games Store, Rally Here, and Atmos backend.",
                    ]),
                new(
                    "Unli Games",
                    "Unity Game Engineer",
                    "Nov 2023 — Feb 2024",
                    "Multiplayer · Photon Quantum",
                    "Competitive Multiplayer",
                    null,
                    null,
                    [
                        "Designed and implemented deterministic multiplayer using Photon Quantum for frame-accurate sync.",
                        "Integrated PlayFab and Azure backend services with runtime asset management for cross-platform compatibility.",
                        "Acted as technical reference for gameplay and networking architecture decisions.",
                    ]),
                new(
                    "Flux Games",
                    "Unity Game Engineer",
                    "Nov 2022 — Nov 2023",
                    "Licensed IP · 6 Platforms",
                    "The Walking Dead: Destinies",
                    "https://store.steampowered.com/app/2192790/The_Walking_Dead_Destinies/",
                    "https://cdn.cloudflare.steamstatic.com/steam/apps/2192790/header.jpg",
                    [
                        "Developed and shipped modular gameplay systems for The Walking Dead: Destinies (GameMill Entertainment) across 6 platforms.",
                        "Implemented complex branching quest flows and multi-phase boss fights.",
                        "Refactored legacy code, improving stability and reducing crash rates across core game loops.",
                    ]),
                new(
                    "Mantra Filmes",
                    "Unity Game Engineer",
                    "Dec 2021 — Mar 2023",
                    "Metroidvania · PC/Console/Mobile",
                    "Elderand",
                    "https://store.steampowered.com/app/1413660/Elderand/",
                    "https://cdn.cloudflare.steamstatic.com/steam/apps/1413660/header.jpg",
                    [
                        "Shipped Elderand, a Metroidvania released on PC, consoles, and mobile with 75K+ units sold.",
                        "Re-architected core game systems — significantly reduced critical bug resolution time.",
                        "Implemented Addressables reducing load time by 85%, from ~6s to under 1s.",
                        "Built custom editor tools cutting level architecture iteration from hours to minutes.",
                        "Implemented Behavior Tree-driven AI for boss encounters + Steam Auto-Cloud save persistence.",
                    ]),
                new(
                    "Z3 Studio",
                    "Unity Mobile Game Engineer",
                    "Jun 2021 — Aug 2021",
                    "Mobile · Performance",
                    "Mobile Game",
                    null,
                    null,
                    [
                        "Developed core gameplay features optimizing mobile builds with Object Pooling for memory management.",
                    ]),
            ],
            ["pt"] =
            [
                new(
                    "Globant",
                    "Game Engineer",
                    "Jan 2026 — Presente",
                    "AAA · Live-Service",
                    "The Sims",
                    "https://www.ea.com/games/the-sims",
                    null,
                    [
                        "Contribuindo para The Sims como parte do time de outsourcing da Globant apoiando a Electronic Arts (EA).",
                        "Desenvolvendo features de gameplay usando Python, C++ e sistemas de tuning data-driven em uma engine AAA proprietária.",
                        "Trabalhando em uma codebase multilinguagem madura de 10+ anos — um live-service com 85M+ jogadores.",
                    ]),
                new(
                    "Big Moxi Games",
                    "Unreal Game Engineer",
                    "Mar 2024 — Dez 2025",
                    "Unreal Engine 5",
                    "Wardens Rising / Exo GP",
                    "https://www.bigmoxigames.com",
                    null,
                    [
                        "Otimizei IA de hordas em Wardens Rising, reduzindo frame time em 20% em combate em tempo real.",
                        "Implementei abilities e ataques de personagens com Unreal Gameplay Ability System (GAS).",
                        "Estabeleci arquitetura de UI data-driven escalável com Common UI e MVVM — redesign do menu principal do Exo GP.",
                        "Gerenciamento de sessão com integrações na Epic Games Store, Rally Here e backend Atmos.",
                    ]),
                new(
                    "Unli Games",
                    "Unity Game Engineer",
                    "Nov 2023 — Fev 2024",
                    "Multiplayer · Photon Quantum",
                    "Multiplayer Competitivo",
                    null,
                    null,
                    [
                        "Projetei e implementei multiplayer determinístico com Photon Quantum para sincronização frame-accurate.",
                        "Integrei PlayFab e Azure com gerenciamento de assets em runtime para compatibilidade cross-platform.",
                        "Atuei como referência técnica para decisões de arquitetura de gameplay e networking.",
                    ]),
                new(
                    "Flux Games",
                    "Unity Game Engineer",
                    "Nov 2022 — Nov 2023",
                    "IP Licenciada · 6 Plataformas",
                    "The Walking Dead: Destinies",
                    "https://store.steampowered.com/app/2192790/The_Walking_Dead_Destinies/",
                    "https://cdn.cloudflare.steamstatic.com/steam/apps/2192790/header.jpg",
                    [
                        "Desenvolvi sistemas de gameplay modulares para The Walking Dead: Destinies (GameMill Entertainment) em 6 plataformas.",
                        "Implementei fluxos de quest com ramificações e boss fights multi-fase.",
                        "Refatorei código legado, melhorando estabilidade e reduzindo crash rates.",
                    ]),
                new(
                    "Mantra Filmes",
                    "Unity Game Engineer",
                    "Dez 2021 — Mar 2023",
                    "Metroidvania · PC/Console/Mobile",
                    "Elderand",
                    "https://store.steampowered.com/app/1413660/Elderand/",
                    "https://cdn.cloudflare.steamstatic.com/steam/apps/1413660/header.jpg",
                    [
                        "Lancei Elderand em PC, consoles e mobile com 75K+ unidades vendidas.",
                        "Rearquitetei sistemas centrais do jogo, reduzindo o tempo de resolução de bugs críticos.",
                        "Implementei Addressables reduzindo o tempo de carregamento em 85%, de ~6s para menos de 1s.",
                        "Construí ferramentas de editor customizadas reduzindo iteração de level design de horas para minutos.",
                        "Implementei IA com Behavior Tree para boss encounters + save persistence com Steam Auto-Cloud.",
                    ]),
                new(
                    "Z3 Studio",
                    "Unity Mobile Game Engineer",
                    "Jun 2021 — Ago 2021",
                    "Mobile · Performance",
                    "Mobile Game",
                    null,
                    null,
                    [
                        "Desenvolvi features de gameplay otimizando builds mobile com Object Pooling para gerenciamento de memória.",
                    ]),
            ],
        };

    public static IReadOnlyDictionary<string, PortfolioCopy> Translations { get; } =
        new Dictionary<string, PortfolioCopy>
        {
            ["en"] = new(
                ["About", "Experience", "Skills", "Education", "Contact"],
                ["about", "experience", "skills", "education", "contact"],
                new HeroContent(
                    "Hello, I'm",
                    "Game Engineer",
                    "Unreal Engine & Unity",
                    "5+ years shipping commercial titles across PC, consoles, and mobile — including AAA and licensed IP productions. Specialized in gameplay engineering, multiplayer systems, and cross-platform performance optimization.",
                    "View Experience",
                    "Get In Touch"),
                "Experience",
                "Skills & Technologies",
                [
                    new("Languages", ["C++", "C#", "Blueprint", "Python", "Java", "JavaScript"]),
                    new("Unreal Engine", ["GAS", "Common UI", "MVVM", "C++", "Blueprint", "UE5"]),
                    new("Unity", ["Photon Quantum", "Addressables", "DOTS/ECS", "Custom Editor"]),
                    new("Networking & Backend", ["PlayFab", "Azure", "Steamworks", "REST APIs", "SQL", "Photon"]),
                    new("Architecture", ["OOP", "SOLID", "MVVM", "Clean Architecture", "DDD", "ECS"]),
                    new("AI & Gameplay", ["Behavior Tree", "FSM", "GOAP", "A*", "Steering Behavior"]),
                    new("Optimization", ["Profiling", "Object Pooling", "Memory Mgmt", "DOTS", "TDD"]),
                    new("Tools & VCS", ["Git", "Perforce", "Plastic SCM", "Jira", "SCRUM", "Agile"]),
                ],
                new EducationContent(
                    "Education & Community",
                    "Bachelor in Information Systems (Ongoing)",
                    "Federal University of Vales do Jequitinhonha e Mucuri",
                    "2023 — 2027",
                    "Community",
                    [
                        new("Educational Content Creator — Idea.ToGame on YouTube", "https://www.youtube.com/@IdeaToGame"),
                        new("Hackathon Organizer & Coordinator — UaiDev Tech Event", null),
                        new("President — ByteBuilders Academic League", null),
                        new("Game Development Project Mentor — ByteBuilders Academic League", null),
                    ]),
                new ContactContent(
                    "Get In Touch",
                    "Open to new opportunities and global collaborations.",
                    "Send Email"),
                "Designed & built by Filipe Durães"),
            ["pt"] = new(
                ["Sobre", "Experiência", "Habilidades", "Educação", "Contato"],
                ["about", "experience", "skills", "education", "contact"],
                new HeroContent(
                    "Olá, eu sou",
                    "Game Engineer",
                    "Unreal Engine & Unity",
                    "5+ anos entregando títulos comerciais para PC, consoles e mobile — incluindo produções AAA e IPs licenciadas. Especializado em engenharia de gameplay, sistemas multiplayer e otimização cross-platform.",
                    "Ver Experiência",
                    "Entrar em Contato"),
                "Experiência",
                "Habilidades & Tecnologias",
                [
                    new("Linguagens", ["C++", "C#", "Blueprint", "Python", "Java", "JavaScript"]),
                    new("Unreal Engine", ["GAS", "Common UI", "MVVM", "C++", "Blueprint", "UE5"]),
                    new("Unity", ["Photon Quantum", "Addressables", "DOTS/ECS", "Custom Editor"]),
                    new("Rede & Backend", ["PlayFab", "Azure", "Steamworks", "REST APIs", "SQL", "Photon"]),
                    new("Arquitetura", ["OOP", "SOLID", "MVVM", "Clean Architecture", "DDD", "ECS"]),
                    new("IA & Gameplay", ["Behavior Tree", "FSM", "GOAP", "A*", "Steering Behavior"]),
                    new("Otimização", ["Profiling", "Object Pooling", "Gerenc. Memória", "DOTS", "TDD"]),
                    new("Ferramentas & VCS", ["Git", "Perforce", "Plastic SCM", "Jira", "SCRUM", "Agile"]),
                ],
                new EducationContent(
                    "Educação & Comunidade",
                    "Bacharelado em Sistemas de Informação (Em Andamento)",
                    "Universidade Federal dos Vales do Jequitinhonha e Mucuri",
                    "2023 — 2027",
                    "Comunidade",
                    [
                        new("Criador de Conteúdo Educacional — Idea.ToGame no YouTube", "https://www.youtube.com/@IdeaToGame"),
                        new("Organizador & Coordenador de Hackathon — UaiDev Tech Event", null),
                        new("Presidente — Liga Acadêmica ByteBuilders", null),
                        new("Mentor de Projetos de Desenvolvimento de Jogos — ByteBuilders", null),
                    ]),
                new ContactContent(
                    "Vamos Conversar",
                    "Aberto a novas oportunidades e colaborações globais.",
                    "Enviar Email"),
                "Desenvolvido por Filipe Durães"),
        };
}
