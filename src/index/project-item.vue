<template>
  <div class="pure-u-1 pure-u-md-1-2 pure-u-lg-1-3 pure-u-xl-1-4">
    <div :class="['project', project.status === 'coming-soon' ? 'coming-soon' : '' ]">
      <h3 class="name">
        <router-link :to="project.router" v-if="project.router">{{project.name}}</router-link>
        <span v-else>{{project.name}}</span>
      </h3>

      <p class="description">{{project.description}}</p>
    </div>
  </div>
</template>

<script>
export default {
  props: {
    project: {
      type: Object,
      required: true
    }
  }
}
</script>

<style lang="stylus" scoped>
section.main .project
  border: 1px solid rgb(90, 90, 90)
  height: 200px
  margin: 1em

section.main .project .name
  margin: 0.5em

section.main .project .name a
  color: rgb(90, 90, 90)
  text-decoration: underline dashed

section.main .project .description
  margin: 0.5em

section.main .project.coming-soon
  color: rgb(200, 196, 186)
  border: 1px solid rgb(200, 196, 186)

section.main .project.coming-soon a
  color: rgb(200, 196, 186)
</style>
