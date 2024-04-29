import { createRouter, createWebHistory } from 'vue-router'
import CadastrarProfessor from '../views/Coordenador/CadastrarProfessorView.vue'
import CadastrarProfessores from '../views/Coordenador/CadastrarProfessores.vue'
import RemoverProfessor from '../views/Coordenador/RemoverProfessor.vue'
import GerarBancas from '../views/Coordenador/GerarBancas.vue'
const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
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
