<template>
  <header>
    <div class="pure-menu pure-menu-horizontal">
      <router-link to="/" class="pure-menu-link pure-menu-heading">
        Bun Web Lab
        <small>beta</small>
      </router-link>
      <div class="pure-menu-heading project-name" v-if="projectName">{{projectName}}</div>
    </div>
  </header>
</template>

<script>
import routers from '../router/router'

export default {
  computed: {
    projectName() {
      let path = this.$route.path
      var route = routers.routes.find(r => r.path === path)

      if (route) {
        return route.title
      }

      return null
    }
  }
}
</script>

<style lang="stylus" scoped>
header
  padding: 0.6em 3em
  background-color: rgb(238, 232, 213)

@media (max-width: 768px)
  header
    padding: 0.6em 1em

header .pure-menu-heading
  text-transform: none
  font-size: 1.1em

header .pure-menu-link
  color: rgb(97, 97, 97)
  background-color: transparent

header .pure-menu-link:hover
  background-color: transparent

header a small
  font-size: 0.6em
  border: 1px solid rgb(114, 114, 114)
  padding: 0.02em 0.4em
  border-radius: 0.8em

header .project-name
  border-left: 1px solid rgb(114, 114, 114)
</style>
