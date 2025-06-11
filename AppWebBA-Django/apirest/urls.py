from django.urls import path
from .views import (
    autenticar,
    obtener_equipos_en_bodega,
    obtener_productos,
    consultar_guias_despacho,  # ← agrégalo aquí
)
# from .views import autenticar,obtener_productos
urlpatterns = [
    path('autenticar/<str:tipousu>/<str:username>/<str:password>/', autenticar, name='autenticar'),
    path('obtener_equipos_en_bodega/', obtener_equipos_en_bodega, name='obtener_equipos_en_bodega'),
    path('obtener_productos/', obtener_productos, name='obtener_productos'),
    path('guias-despacho/',consultar_guias_despacho,name='consultar_guias_despacho'
    ),
]