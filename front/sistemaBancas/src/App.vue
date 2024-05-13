<script setup lang="ts">
import { ref, provide } from 'vue';
import SideBar from './components/SideBar.vue';
import Login from './views/Login.vue';

let isLoggedIn = ref(false);

</script>

<template>
   <SideBar v-if="isLoggedIn"></SideBar>
   <Login v-else @login="isLoggedIn = true"></Login>
</template>

<style scoped>

</style>
 