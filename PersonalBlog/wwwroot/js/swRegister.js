if ('serviceWorker' in navigator)
{
    navigator.serviceWorker.register('/sw.js')
        .then(function (registration)
        {
            console.log('service worker registrado com sucesso.', registration.scope);
        }, function (error) {
            console.log('falha ao registrar servicesworker', error);
        }
        ).catch()
}