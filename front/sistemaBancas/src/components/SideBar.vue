<script>
import { RouterLink, RouterView } from 'vue-router'

export default {
  data() {
    return {
      userType: 'professor' 
    }
  }
}
</script>

<template>
    <div id="app">
      <nav class="sidebar">
        <div class="logo-container">
            <img src="@/assets/logo-unisinos-menu.png" alt="Logo Unisinos">
        </div>
        
        <ul class="lista" v-if="userType === 'coordenador'">
          <li class="item">
            <RouterLink to="/cadastrarProfessor">Cadastrar Professor</RouterLink>
          </li>
          <li class="item">
            <RouterLink to="/cadastrarProfessores">Cadastrar Professores</RouterLink>
          </li>
          <li class="item">
            <RouterLink to="/removerProfessor">Remover Professor</RouterLink>
          </li>
          <li class="item">
            <RouterLink to="/gerarBancas">Gerar Bancas</RouterLink>
          </li>
        </ul>
        <ul class="lista" v-else-if="userType === 'professor'">
          <li class="item">
            <RouterLink to="/registrarHorarios">Registrar Meus Horários</RouterLink>
          </li>
          <li class="item">
            <RouterLink to="/visualizarMinhasBancas">Visualizar Minhas Bancas</RouterLink>
          </li>
        </ul>
        <ul class="lista" v-else-if="userType === 'aluno'">
            <li class="item">
              <RouterLink to="/registrarTCC">Registrar TCC</RouterLink>
            </li>
            <li class="item">
              <RouterLink to="/visualizarMinhaBanca">Visualizar Minha Banca</RouterLink>
            </li>
        </ul>
      </nav>

    </div>
    <RouterView />
  </template>

  
  <style>
  /* Estilo da barra lateral */
  .sidebar {
    width: 300px;
    background-color: #214099;
    position: fixed;
    top: 0;
    left: 0;
    height: 100%;
    transition: left 0.3s ease;
    align-items: center;
  }

  .logo-container {
    display: flex;
    justify-content: center;
    padding-top: 20px;
  }   

  .lista {
    padding-top: 30px;
    list-style: none;
  }

  .item {
    padding-top: 15px;
    font-size: 18px;
    color: white;
    font-weight: bold;
  }

  .item:hover{
    color: #0c1738;
    cursor: pointer;
  }
  
  /* Estilo do conteúdo principal */
  .main-content {
    margin-left: 200px; /* Espaçamento para a barra lateral */
    padding: 20px;
  }
  </style>
  