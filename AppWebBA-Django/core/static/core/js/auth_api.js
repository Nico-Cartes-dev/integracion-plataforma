// const url = `/apirest/autenticar/${tipousu}/${username}/${password}/`;
const url = `http://localhost:8000/apirest/autenticar/${tipousu}/${username}/${password}/`;

const validRoles = ['Administrador', 'Cliente', 'Técnico', 'Bodeguero', 'Vendedor'];

if (!validRoles.includes(tipousu)) {
    alert('Tipo de usuario no válido');
    return;
}

fetch(url, {
    method: 'GET',
    headers: {
        'Content-Type': 'application/json'
    }
})
.then(response => response.json())
.then(data => {
    if (data.Autenticado) {
        
        sessionStorage.setItem('NombreUsuario', data.NombreUsuario);
        sessionStorage.setItem('TipoUsuario', data.TipoUsuario);
        
        window.location.href = '/';
    } else {
        alert(data.Mensaje);
    }
});