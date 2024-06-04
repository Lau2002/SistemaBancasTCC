<script setup lang="ts">
import { ref, onMounted } from 'vue';
import SideBar from './components/SideBar.vue';
import Login from './views/Login.vue';

let isLoggedIn = ref(false);

/*onMounted(() => {
  const savedStatus = localStorage.getItem('isLoggedIn');
  if (savedStatus) {
    isLoggedIn.value = JSON.parse(savedStatus);
  }
});*/

// Atualizar o localStorage quando o estado de login mudar
const updateLoginStatus = (status: boolean) => {
  isLoggedIn.value = status;
  localStorage.setItem('isLoggedIn', JSON.stringify(status));
};

</script>

<template>
   <SideBar v-if="isLoggedIn"></SideBar>
   <Login v-else @login="updateLoginStatus(true)"></Login>
</template>

<style scoped>

</style>
 