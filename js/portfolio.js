window.portfolio = {
    scrollTo: function (id) {
        const el = document.getElementById(id);
        if (el) {
            el.scrollIntoView({ behavior: 'smooth' });
        }
    },
    registerScrollSpy: function (dotnetRef, sectionIds) {
        let frame = 0;

        const updateActiveSection = function () {
            const pageBottom = window.scrollY + window.innerHeight;
            const isAtBottom =
                pageBottom >= document.documentElement.scrollHeight - 2;

            if (isAtBottom) {
                const lastId = sectionIds[sectionIds.length - 1] || '';
                dotnetRef.invokeMethodAsync('OnActiveSectionChanged', lastId);
                frame = 0;
                return;
            }

            const navBottom =
                document.querySelector('.nav-shell')?.getBoundingClientRect()
                    .bottom ?? 76;
            const marker = navBottom + 8;
            const current = sectionIds.find((id) => {
                const section = document.getElementById(id);
                if (!section) return false;

                const bounds = section.getBoundingClientRect();
                return bounds.top <= marker && bounds.bottom > marker;
            });

            dotnetRef.invokeMethodAsync(
                'OnActiveSectionChanged',
                current || ''
            );
            frame = 0;
        };

        const handleScroll = function () {
            if (!frame) {
                frame = window.requestAnimationFrame(updateActiveSection);
            }
        };

        updateActiveSection();
        window.addEventListener('scroll', handleScroll, { passive: true });
        window.addEventListener('resize', handleScroll);

        return {
            dispose: function () {
                window.removeEventListener('scroll', handleScroll);
                window.removeEventListener('resize', handleScroll);
                if (frame) {
                    window.cancelAnimationFrame(frame);
                }
            }
        };
    }
};
