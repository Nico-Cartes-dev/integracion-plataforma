from rest_framework.decorators import api_view
from django.views.decorators.csrf import csrf_exempt
from django.http import JsonResponse
from django.contrib.auth import authenticate
from core.models import PerfilUsuario
from django.db import connection

@csrf_exempt
@api_view(['GET'])
def autenticar(request, tipousu, username, password):
    user = authenticate(username=username, password=password)
    if user:
        perfil = PerfilUsuario.objects.get(user=user)
        nombre = f'{user.first_name} {user.last_name}'
        tipo = perfil.tipousu
        if tipo in [tipousu, 'Administrador']:
            return JsonResponse({'Autenticado': True, 'NombreUsuario': nombre, 'TipoUsuario': tipo, 'Mensaje': ''})
        msg = f'La cuenta de usuario {nombre} es del perfil {tipo}, por lo que no puede ingresar al sistema'
    else:
        nombre, tipo, msg = '', '', 'La cuenta o la contraseña no coinciden con un usuario válido'
    return JsonResponse({'Autenticado': False, 'NombreUsuario': nombre, 'TipoUsuario': tipo, 'Mensaje': msg})

def obtener_equipos_en_bodega (request):
    if request.method == 'GET':
        cursor = connection.cursor()

        #proceso almacenado
        cursor.execute("exec sp_obtener_equipos_en_bodega")

        #convertir los resultados 
        resultados = cursor.fetchall()

        #convertir los resultados a una lista de diccionarios
        data = []
        for row in resultados:
            idstock = row[0]
            idproducto = row[1]
            nomprod = row[2]
            nrofac = row[3]
            estado = row[4]
            data.append({
                'idstock': idstock,
                'idproducto': idproducto,
                'nomprod': nomprod,
                'nrofac': nrofac,
                'estado': estado
            })
        return JsonResponse(data, safe=False)
@csrf_exempt
@api_view(['GET'])
# direccion
# http://127.0.0.1:8001/BuenosAiresApiRest/obtener_productos
def obtener_productos(request):
    try:
        with connection.cursor() as cursor:
            cursor.callproc('SP_OBTENER_PRODUCTOS')
            productos = cursor.fetchall()
            columns = [col[0] for col in cursor.description]
            productos_list = [
                {
                    'idprod': producto[0],
                    'nomprod': producto[1],
                    'descprod': producto[2],
                    'precio': float(producto[3]),
                    'imagen': producto[4] if producto[4] else None
                }
                for producto in productos
            ]
            return JsonResponse({'productos': productos_list})
    except Exception as e:
        return JsonResponse({'error': str(e)}, status=500)

