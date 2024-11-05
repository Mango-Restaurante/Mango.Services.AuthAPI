

<h1>🍈 Mango.Services.AuthAPI</h1>

<p>Este proyecto es una API de autenticación desarrollada en .NET 8.0 que utiliza <strong>JWT</strong> y <strong>.NET Identity</strong> para manejar la autenticación y autorización de usuarios. La API está diseñada para integrarse con otros servicios y aplicaciones de la plataforma <strong>Mango</strong>.</p>

<h2>✨ Funcionalidades</h2>
<ul>
    <li>🔐 <strong>Autenticación con JWT</strong>: Implementación de <em>JSON Web Tokens</em> para asegurar las solicitudes de usuarios.</li>
    <li>👤 <strong>Integración con .NET Identity</strong>: Configuración de <em>.NET Identity</em> para el manejo de usuarios y roles.</li>
    <li>📋 <strong>Endpoints de Autenticación</strong>: Desarrollo de endpoints de inicio de sesión y registro de usuarios.</li>
    <li>💼 <strong>DTOs (Data Transfer Objects)</strong>: Definición de DTOs para el manejo de solicitudes y respuestas en el proceso de autenticación.</li>
</ul>

<h2>📂 Estructura del Proyecto</h2>
<ul>
    <li><strong>Controllers</strong>: Controladores de la API, manejan las solicitudes de autenticación (Login, Register).</li>
    <li><strong>Data</strong>: Contiene los DTOs creados para la autenticación (Login y Request).</li>
    <li><strong>Migrations</strong>: Migraciones para configurar la base de datos del servicio de autenticación.</li>
    <li><strong>Models</strong>: Modelos de datos de la API, configurados para trabajar con JWT.</li>
    <li><strong>Properties</strong>: Configuraciones básicas del proyecto, incluyendo los archivos de settings.</li>
    <li><strong>Service</strong>: Contiene la interfaz <code>AuthService</code> y su implementación, manejando la lógica de autenticación.</li>
</ul>

<h2>⚙️ Configuración</h2>

<h3>🔑 JWT (JSON Web Tokens)</h3>
<p>La configuración de JWT se encuentra en el archivo <code>appsettings.json</code> y en <code>Program.cs</code>, donde se define la clave secreta y los parámetros necesarios para generar y validar tokens.</p>

<h3>👥 .NET Identity</h3>
<p>Se ha comenzado la configuración de <em>.NET Identity</em> en el archivo <code>Mango.Services.AuthAPI.csproj</code>, integrando la administración de usuarios y roles.</p>

<h2>📋 Requisitos Previos</h2>
<ul>
    <li><strong>.NET SDK 8.0</strong> o superior.</li>
    <li><strong>SQL Server</strong> (o un servidor de base de datos compatible para manejar la persistencia de usuarios).</li>
</ul>

<h2>🚀 Instalación</h2>
<ol>
    <li>Clonar el repositorio:
        <pre><code>git clone https://github.com/tu-usuario/Mango.Services.AuthAPI.git</code></pre>
    </li>
    <li>Restaurar los paquetes de NuGet:
        <pre><code>dotnet restore</code></pre>
    </li>
    <li>Configurar la base de datos y migraciones:
        <pre><code>dotnet ef database update</code></pre>
    </li>
    <li>Ejecutar el proyecto:
        <pre><code>dotnet run</code></pre>
    </li>
</ol>

<h2>🔑 Endpoints Principales</h2>
<ul>
    <li><strong>POST</strong> <code>/api/auth/login</code>: Permite iniciar sesión y recibir un token JWT en respuesta.</li>
    <li><strong>POST</strong> <code>/api/auth/register</code>: Permite registrar un nuevo usuario.</li>
</ul>

<h2>⏳ Pendiente</h2>
<p>⚠️ Finalizar la implementación de los endpoints en el <code>AuthService</code>.</p>

<h2>💬 Contacto</h2>
<p>Este proyecto forma parte de la plataforma Mango. Si tienes alguna pregunta o deseas contribuir, por favor, crea un issue o realiza un pull request.</p>

</body>
</html>
