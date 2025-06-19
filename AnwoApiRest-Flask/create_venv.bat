cls
call rmdir /s /q C:\BuenosAires\integracion-plataforma\AnwoApiRest-Flask\.venv
call python -m pip install --upgrade pip
call pip install --upgrade virtualenv
call python -m venv "C:\BuenosAires\integracion-plataforma\AnwoApiRest-Flask\.venv"
call cd /D "C:\BuenosAires\integracion-plataforma\AnwoApiRest-Flask\"
call .venv\Scripts\activate.bat
call python -m pip install --upgrade pip
call pip install flask
call pip install pyodbc
call pip install requests
call py create-store-procedures.py