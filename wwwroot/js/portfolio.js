window.portfolio = {
    scrollTo: function (id) {
        const el = document.getElementById(id);
        if (el) {
            el.scrollIntoView({ behavior: 'smooth' });
        }
    },
    registerScroll: function (dotnetRef) {
        const handler = function () {
            dotnetRef.invokeMethodAsync('OnScroll', window.scrollY > 48);
        };
        window.addEventListener('scroll', handler, { passive: true });
        handler();
        return {
            dispose: function () {
                window.removeEventListener('scroll', handler);
            }
        };
    }
};
