from django.urls import path
from .views import autenticar, obtener_equipos_en_bodega, obtener_productos
# from .views import autenticar,obtener_productos
urlpatterns = [
    path('autenticar/<str:tipousu>/<str:username>/<str:password>/', autenticar, name='autenticar'),
    path('obtener_equipos_en_bodega/', obtener_equipos_en_bodega, name='obtener_equipos_en_bodega'),
    path('obtener_productos/', obtener_productos, name='obtener_productos'),
]