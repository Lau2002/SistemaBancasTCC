<script>
export default {
    data() {
    return {
      userType: 'aluno' // Altere isso para 'user' ou qualquer outro valor para testar
    }
  },
  methods: {
    validarLogin() {
      this.$emit('login');
      if (this.userType === 'coordenador') 
        this.$router.push('/cadastrarProfessor');
        else if (this.userType === 'professor')
        this.$router.push('/registrarHorarios');
        else if(this.userType === 'aluno')
        this.$router.push('/registrarTCC')
    }
  }
}

</script>

<template>
    <body class="body-container">
        <div class="login-container">
            <div class="container-logo"><img src="@/assets/unisinos-logo-vs.png" alt="Logo Unisinos"></div>
            <div class="container-titulo">
                <h1 class="titulo-login">Bem-Vindo(a) ao Sistema de Bancas de TCC</h1>
            </div>
            <form class="form-login">
                <div class="form-group">
                    <input type="text" class="form-control" id="Nome" placeholder="Nome">
                </div>
                <div class="form-group">
                    <input type="password" class="form-control" id="Senha" placeholder="Senha">
                </div>
                <button type="button" class="btn btn-primary" v-on:click="validarLogin">Entrar</button>
            </form>
        </div>
    </body>
</template>

<style>
    .body-container {
        display: flex;
        align-items: center;
        justify-content: center;
    }

    .login-containeter {
        display: flex;
        align-items: center;
        justify-content: center;
        gap: 20px;
        text-align: center;
    }
    .container-logo {
        display: flex;
        justify-content: center;
    }

    .container-titulo {
        display: flex;
        justify-content: center;
    }

    .titulo-login {
        text-align: center;
        padding-left: 0px;
        width: 350px;
        font-weight: bolder;
    }

    .form-login {
        padding-left: 20px;
        display: flex;
        align-items: center;
        flex-direction: column;
    }

    #Nome {
        width: 300px;
    }

    #Senha {
        width: 300px;
    }

</style>