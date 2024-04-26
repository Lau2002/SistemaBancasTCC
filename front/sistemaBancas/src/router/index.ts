import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import CadastrarProfessor from '../views/CadastrarProfessor.vue'
import CadastrarProfessores from '../views/CadastrarProfessores.vue'
import RemoverProfessor from '../views/RemoverProfessor.vue'
import GerarBancas from '../views/GerarBancas.vue'
const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      component: HomeView
    },
    {
      path: '/cadastrarProfessor',
      name: 'cadastrarProfessor',
      component: CadastrarProfessor
    },
    {
      path: '/cadastrarProfessores',
      name: 'cadastrarProfessores',
      component: CadastrarProfessores
    },
    {
      path: '/removerProfessor',
      name: 'removerProfessor',
      component: RemoverProfessor
    },
    {
      path: '/gerarBancas',
      name: 'gerarBancas',
      component: GerarBancas
    }
  ]
})

export default router
